using StoriesHelper.Repository;
using StoriesHelper.Models;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using FluentDate;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    public partial class TeamGraphicsAdvanced : UserControl
    {
        protected int idTeam;
        public TeamGraphicsAdvanced(int idTeam)
        {
            InitializeComponent();
            ColumnStateRepository TaskStateRepository = new ColumnStateRepository();
            this.idTeam = idTeam;
            Team Team = new Team(idTeam);
            List<Column> Columns = Team.getListColumns();
            List<Task> Tasks = new List<Task>();

            DateTime DateBegin = DateTime.Now - 2.Weeks();
            DateTime DateEnd = DateTime.Now;


            string dateBegin = DateBegin.ToString("yyyy-MM-dd");
            string dateEnd = DateTime.Now.ToString("yyyy-MM-dd");

            string series = "";

            List<string> columnNames = TaskStateRepository.fetchDistinctColumnBetweenDate(idTeam, dateBegin, dateEnd, "jour");
            foreach (string columnName in columnNames)
            {
                series = columnName;
                TeamGraphics.Series.Add(series);
                TeamGraphics.Series[series].ChartType = SeriesChartType.StackedArea100;
            }

            while (DateBegin <= DateEnd)
            {
                dateBegin = DateBegin.ToString("yyyy-MM-dd");
                List<ColumnState> ColumnStates = TaskStateRepository.fetchBackupColumn(idTeam, dateBegin, "jour");
                foreach (string columnName in columnNames)
                {
                    bool verif = true;
                    series = columnName;
                    foreach (ColumnState ColumnState in ColumnStates)
                    {
                        if(ColumnState.getColumnName() == columnName)
                        {
                            TeamGraphics.Series[series].Points.AddXY(DateBegin.ToString("dd"), ColumnState.getNbTask());
                            verif = false;
                            continue;
                        }
                    }

                    if (verif)
                    {
                        TeamGraphics.Series[series].Points.AddXY(DateBegin.ToString("dd"), 0);
                    }
                }

                DateBegin = DateBegin + 1.Days();
            }
        }
    }
}
