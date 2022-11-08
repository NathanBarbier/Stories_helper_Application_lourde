using StoriesHelper.Services;
using StoriesHelper.Repository;
using System;
using System.Collections.Generic;
using StoriesHelper.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Projects.ProjectListTeam
{
    public partial class ProjectListTeams : UserControl
    {
        protected int idProject;
        public ProjectListTeams(int idProject, int page = 0, string name = "")
        {
            InitializeComponent();
            this.idProject = idProject;
            TeamRepository teamRepository = new TeamRepository();
            List<TeamNameType> Teams = teamRepository.GetTeamsByProjects(idProject, true, true, page, name);

            int positionLabel = 10;
            int positionButton = 7;
            int positionBackColor = 0;
            int rang = 0;

            foreach (TeamNameType Team in Teams)
            {
                int countUser = teamRepository.GetCountUser(Team.id, true, true, page, name); 
                int countTask = teamRepository.GetCountTask(Team.id, true, true, page, name); 
                // créer le fond coloré.
                Gradient BackColor = new Gradient();
                BackColor.Name = "BackColor" + Team.id.ToString();
                BackColor.Location = new Point(1, positionBackColor);
                BackColor.Size = new Size(598, 40);
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
                if (TeamName.Length > 40)
                {
                    newName = TeamName.Remove(40, (TeamName.Length - 40));
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


                // Créer le countUser
                Gradient PanelUser = new Gradient();
                PanelUser.BackColor = Color.Transparent;
                PanelUser.Size = new Size(80, 50);
                PanelUser.Location = new Point(300, positionLabel);
                BackColor.Controls.Add(PanelUser);

                Label Users = new Label();
                Users.Name = "UsersCount" + Team.id;
                Users.Text = countUser.ToString();
                Users.BackColor = Color.Transparent;
                Users.UseMnemonic = true;
                Users.AutoSize = true;
                Users.Location = new Point(20, 0);
                Users.Font = new Font("Cambria", 11);
                PanelUser.Controls.Add(Users);
                Users.Left = (80 - Users.Width) / 2;

                // Créer le countTask
                Gradient PanelTask = new Gradient();
                PanelTask.BackColor = Color.Transparent;
                PanelTask.Size = new Size(80, 50);
                PanelTask.Location = new Point(410, positionLabel);
                BackColor.Controls.Add(PanelTask);

                Label Tasks = new Label();
                Tasks.Name = "UsersTask" + Team.id;
                Tasks.Text = countTask.ToString();
                Tasks.BackColor = Color.Transparent;
                Tasks.UseMnemonic = true;
                Tasks.AutoSize = true;
                Tasks.Font = new Font("Cambria", 11);
                Tasks.Location = new Point(20, 0);
                PanelTask.Controls.Add(Tasks);
                Tasks.Left = (80 - Tasks.Width) / 2;


                // Créer Le button
                Button button = new Button();
                button.Name = Team.id.ToString();
                button.Text = "Aller à";
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Gray;
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(500, positionButton);
                button.Click += new EventHandler(goToTeam);
                BackColor.Controls.Add(button);

                // Créer la ligne
                LigneHorizontale LigneHorizontale = new LigneHorizontale();
                LigneHorizontale.Name = "Ligne" + Team.id.ToString();
                LigneHorizontale.Location = new Point(0, 0);
                LigneHorizontale.Width = 600;
                LigneHorizontale.Height = 1;
                BackColor.Controls.Add(LigneHorizontale);

                positionBackColor += 40;

                // Créer la ligne
                LigneHorizontale LastLigneHorizontale = new LigneHorizontale();
                LastLigneHorizontale.Name = "LigneHorizontale";
                LastLigneHorizontale.Location = new Point(0, positionBackColor);
                LastLigneHorizontale.Width = 600;
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
            RightLigneVerticale.Location = new Point(599, 0);
            RightLigneVerticale.Width = 1;
            RightLigneVerticale.Height = positionBackColor;
            Controls.Add(RightLigneVerticale);
        }

        private void goToTeam(object sender, EventArgs e)
        {
            Button button = sender as Button;
            main.goToTeam(Convert.ToInt32(button.Name), "Project");
        }
    }
}
