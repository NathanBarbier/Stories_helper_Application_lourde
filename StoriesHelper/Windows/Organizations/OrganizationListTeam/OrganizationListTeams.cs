using StoriesHelper.Services;
using StoriesHelper.Repository;
using System;
using System.Collections.Generic;
using StoriesHelper.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations
{
    public partial class OrganizationListTeams : UserControl
    {
        public OrganizationListTeams(bool archived = false, bool open = true, int page = 0, string name= "")
        {
            InitializeComponent();
            TeamRepository teamRepository = new TeamRepository();
            List<TeamNameType> Teams = teamRepository.GetTeamsByOrganization(Session.UserId, open, archived, page, name);

            int positionLabel = 10;
            int positionButton = 7;
            int positionBackColor = 0;
            int rang = 0;

            foreach (TeamNameType Team in Teams)
            {
                // créer le fond coloré.
                Gradient BackColor = new Gradient();
                BackColor.Name = "BackColor" + Team.id.ToString();
                BackColor.Location = new Point(1, positionBackColor);
                BackColor.Size = new Size(498, 40);
                if (rang % 2 == 0)
                {
                    BackColor.BackColor = Color.FromArgb(66, 0, 0, 0);
                }
                else
                {
                    BackColor.BackColor = Color.FromArgb(33, 0, 0, 0);
                }
                this.Controls.Add(BackColor);

                // Créer le label
                string TeamName = Team.name;
                string newName = "";
                Label Label = new Label();
                Label.BackColor = Color.Transparent;
                if (TeamName.Length > 50)
                {
                    newName = TeamName.Remove(50, (TeamName.Length - 50));
                    newName = newName.Insert(newName.Length, "...");
                    Label.Text = "- " + newName;
                    Label.Name = newName + Team.id;
                }
                else
                {
                    Label.Text = "- " + TeamName;
                    Label.Name = TeamName + Team.id;
                }
                Label.UseMnemonic = true;
                Label.AutoSize = true;
                if (!Team.active)
                {
                    Label.ForeColor = Color.Red;
                }
                Label.Font = new Font("Cambria", 11);
                Label.Location = new Point(1, positionLabel);
                BackColor.Controls.Add(Label);

                // Créer Le button
                Button button = new Button();
                button.Name = Team.id.ToString();
                button.Text = "Aller à";
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Gray;
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(400, positionButton);
                button.Click += new EventHandler(goToTeam);
                BackColor.Controls.Add(button);

                // Créer la ligne
                LigneHorizontale LigneHorizontale = new LigneHorizontale();
                LigneHorizontale.Name = "Ligne" + Team.id.ToString();
                LigneHorizontale.Location = new Point(0, 0);
                LigneHorizontale.Width = 500;
                LigneHorizontale.Height = 1;
                BackColor.Controls.Add(LigneHorizontale);

                positionBackColor += 40;

                // Créer la ligne
                LigneHorizontale LastLigneHorizontale = new LigneHorizontale();
                LastLigneHorizontale.Name = "LigneHorizontale";
                LastLigneHorizontale.Location = new Point(0, positionBackColor);
                LastLigneHorizontale.Width = 500;
                LastLigneHorizontale.Height = 1;
                Controls.Add(LastLigneHorizontale);
                rang += 1;
            }

            LigneVerticale LeftLigneVerticale = new LigneVerticale();
            LeftLigneVerticale.Name = "LigneVerticale";
            LeftLigneVerticale.Location = new Point(0, 0);
            LeftLigneVerticale.Width = 1;
            LeftLigneVerticale.Height = positionBackColor;
            Controls.Add(LeftLigneVerticale);

            LigneVerticale RightLigneVerticale = new LigneVerticale();
            RightLigneVerticale.Name = "LigneVerticale";
            RightLigneVerticale.Location = new Point(499, 0);
            RightLigneVerticale.Width = 1;
            RightLigneVerticale.Height = positionBackColor;
            Controls.Add(RightLigneVerticale);
        }

        private void goToTeam(object sender, EventArgs e)
        {
            Button button = sender as Button;
            main.goToTeam(Convert.ToInt32(button.Name), "Organization");
        }
    }
}
