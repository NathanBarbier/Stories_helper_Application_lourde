using FluentDate;
using FluentDateTime;
using System;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using System.Collections.Generic;

namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    public partial class TitreStatistique : UserControl
    {
        protected int idTeam;
        public TitreStatistique(int idTeam, string scope, int relativeDate)
        {
            InitializeComponent();
            this.idTeam = idTeam;
            DateTime DateBegin = DateTime.Now;
            DateTime DateEnd = DateTime.Now;
            string date = "";
            string begin = "";
            string end = "";
            bool ret = calculateTime(scope, relativeDate, out DateBegin, out DateEnd, out begin, out end, out date);

            AfficherTitre(scope, DateBegin);

            Titre.Left = (this.ClientSize.Width - Titre.Width) / 2;
        }

        private void AfficherTitre(string scope, DateTime DateBegin)
        {
            switch (scope)
            {
                case "jour":
                    Titre.Text = DateBegin.ToString("dd/MM/yyyy");
                    break;
                case "semaine":
                    int week = CalculateWeeks(DateBegin);
                    Titre.Text = DateBegin.ToString("yyyy") + " Semaine " + week;
                    break;
                case "mois":
                    string month = DateBegin.ToString("MMMM").First().ToString().ToUpper() + DateBegin.ToString("MMMM").Substring(1);
                    Titre.Text = month + " " + DateBegin.ToString("yyyy");
                    break;
                case "annee":
                    Titre.Text = "Année " + DateBegin.ToString("yyyy");
                    break;
            }
        }

        private int CalculateWeeks(DateTime DateWeekBegin)
        {
            DateTime beginOfTheYear = DateTime.Now.BeginningOfYear();

            while(DateWeekBegin.BeginningOfYear() != beginOfTheYear)
            {
                if(DateWeekBegin.BeginningOfYear() < beginOfTheYear)
                {
                    DateWeekBegin = DateWeekBegin.NextYear();
                } else
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

        private bool calculateTime(string scope, int relativeDate,out DateTime DateBegin, out DateTime DateEnd, out string begin, out string end, out string Date)
        {
            DateBegin = DateTime.Now;
            DateEnd = DateTime.Now;
            Date = "";
            begin = "";
            end = "";
            switch (scope)
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
                switch (scope)
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
                        Date = DateBegin.ToString("yyyy-MM") + "%";
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
    }
}
