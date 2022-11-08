using StoriesHelper.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FluentDateTime;
using FluentDate;
using StoriesHelper.Repository;
using StoriesHelper.Services;

namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    public partial class TeamTaskGraphics : UserControl
    {
        protected int idTeam;
        protected string scope;
        protected int relativeDate;

        public TeamTaskGraphics(int idTeam, string scope, int relativeDate)
        {
            InitializeComponent();
            ColumnStateRepository TaskStateRepository = new ColumnStateRepository();
            this.idTeam = idTeam;
            Team Team = new Team(idTeam);
            List<Column> Columns = Team.getListColumns();
            List<Task> Tasks = new List<Task>();
            DateTime DateBegin = DateTime.Now;
            DateTime DateEnd = DateTime.Now;
            string date = "";
            string begin = "";
            string end = "";

            bool ret = calculateTime(scope, relativeDate, out DateBegin, out DateEnd, out begin, out end, out date);

            Columns = Columns.OrderBy(c => c.getRank()).ToList();

            if (relativeDate == 0)
            {
                foreach (Column Column in Columns)
                {
                     Tasks = Column.fetchTaskBetweenTime(Column.getRowId(), begin, end);
                     TeamGraphicsStat.Series["Nombre de Tâches"].Points.AddXY(Column.getName(), Tasks.Count());
                }
            }
            else
            {
                List<ColumnState> ColumnStates = TaskStateRepository.fetchBackupColumn(idTeam, date, scope);
                if (ColumnStates.Count != 0) 
                {
                    foreach (ColumnState ColumnState in ColumnStates)
                    {

                         TeamGraphicsStat.Series["Nombre de Tâches"].Points.AddXY(ColumnState.getColumnName(), ColumnState.getNbTask());
                    }
                }
                else
                {
                    TeamGraphicsStat.Series["Nombre de Tâches"].Points.AddXY("No Data", 0);
                }
            }

            TitreStatistique TitreStatistique = new TitreStatistique(idTeam, scope, relativeDate);
            PanelTitreStatistique.Controls.Clear();
            PanelTitreStatistique.Controls.Add(TitreStatistique);
            TitreStatistique.Show();
        }

        private bool calculateTime(string date, int relativeDate, out DateTime DateBegin, out DateTime DateEnd, out string begin, out string end, out string Date)
        {
            DateBegin = DateTime.Now;
            DateEnd = DateTime.Now;
            Date = "";
            begin = "";
            end = "";
            switch (date)
            {
                case "semaine":
                    DateBegin = DateBegin.BeginningOfWeek();
                    DateEnd = DateEnd.EndOfWeek();
                    break;
                case "mois":
                    DateBegin = DateBegin.BeginningOfMonth();
                    DateEnd = DateEnd.EndOfMonth();
                    break;
                case "annee":
                    DateBegin = DateBegin.BeginningOfYear();
                    DateEnd = DateEnd.EndOfYear();
                    break;
            }
            if (relativeDate != 0)
            {
                switch (date)
                {
                    case "jour":
                        DateBegin = DateBegin + relativeDate.Days();
                        DateEnd = DateEnd + relativeDate.Days();
                        Date = DateEnd.ToString("yyyy-MM-dd");
                        break;
                    case "semaine":
                        DateBegin = DateBegin + relativeDate.Weeks();
                        DateEnd = DateEnd + relativeDate.Weeks();
                        Date = DateEnd.ToString("yyyy-MM-dd");
                        break;
                    case "mois":
                        DateBegin = DateBegin + relativeDate.Months();
                        DateEnd = DateEnd + relativeDate.Months();
                        Date = DateEnd.ToString("yyyy-MM") + "%";
                        break;
                    case "annee":
                        DateBegin = DateBegin + relativeDate.Years();
                        DateEnd = DateEnd + relativeDate.Years();
                        Date = DateEnd.ToString("yyyy") + "%";
                        break;
                }
            }

            begin = DateBegin.ToString("yyyy-MM-dd 00:00:00");
            end = DateEnd.ToString("yyyy-MM-dd 23:59:59");

            return true;
        }

        private int CalculateWeeks(DateTime DateWeekBegin)
        {
            DateTime beginOfTheYear = DateTime.Now.BeginningOfYear();

            while (DateWeekBegin.BeginningOfYear() != beginOfTheYear)
            {
                if (DateWeekBegin.BeginningOfYear() < beginOfTheYear)
                {
                    DateWeekBegin = DateWeekBegin.NextYear();
                }
                else
                {
                    DateWeekBegin = DateWeekBegin.PreviousYear();
                }
            }

            int week = 0;
            while (beginOfTheYear < DateWeekBegin)
            {
                beginOfTheYear = beginOfTheYear.WeekAfter();
                week++;
            }
            return week;
        }

    }
}
