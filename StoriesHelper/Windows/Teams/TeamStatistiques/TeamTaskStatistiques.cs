using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    public partial class TeamTaskStatistiques : UserControl
    {
        protected int idTeam;
        protected string date;
        protected int relativeDate;
        public TeamTaskStatistiques(int idTeam)
        {
            InitializeComponent();
            this.idTeam = idTeam;
            relativeDate = 0;
            date = "mois";

            TeamTaskGraphics TeamTaskGraphics = new TeamTaskGraphics(idTeam, date, relativeDate);
            PanelTeamTaskGraphics.Controls.Clear();
            PanelTeamTaskGraphics.Controls.Add(TeamTaskGraphics);
            TeamTaskGraphics.Show();
        }

        private void btnDateGraphics(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "precedent":
                    relativeDate--;
                    break;
                case "suivant":
                    relativeDate++;
                    break;
                default:
                    relativeDate = 0;
                    date = button.Name;
                    precedent.BackColor = precedent.Name == date ? Color.Gray : Color.Transparent;
                    jour.BackColor = jour.Name == date ? Color.Gray : Color.Transparent;
                    semaine.BackColor = semaine.Name == date ? Color.Gray : Color.Transparent;
                    mois.BackColor = mois.Name == date ? Color.Gray : Color.Transparent;
                    annee.BackColor = annee.Name == date ? Color.Gray : Color.Transparent;
                    suivant.BackColor = suivant.Name == date ? Color.Gray : Color.Transparent;

                    break;
            }

            TeamTaskGraphics TeamTaskGraphics = new TeamTaskGraphics(idTeam, date, relativeDate);
            PanelTeamTaskGraphics.Controls.Clear();
            PanelTeamTaskGraphics.Controls.Add(TeamTaskGraphics);
            TeamTaskGraphics.Show();
        }
    }
}
