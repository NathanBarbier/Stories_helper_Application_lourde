using StoriesHelper.Models;
using StoriesHelper.Services;
using StoriesHelper.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations
{
    public partial class OrganizationListProjects : UserControl
    {
        public OrganizationListProjects(bool archived = false, bool open = true, int page = 0, string name = null, string type = null)
        {
            InitializeComponent();

            ProjectRepository projectRepository = new ProjectRepository();
            List<ProjectNameType> Projects = projectRepository.GetProjectsByOrganization(Session.UserId, archived, open, page, name, type);

            int positionLabel = 10;
            int positionButton = 7;
            int positionBackColor = 0;
            int rang = 0;

            foreach (ProjectNameType Project in Projects)
            {
                // créer le fond coloré.
                Gradient BackColor = new Gradient();
                BackColor.Name = "BackColor" + Project.id.ToString();
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
                string projectName = Project.name;
                string newName = "";
                Label Label = new Label();
                Label.BackColor = Color.Transparent;
                if (projectName.Length > 30)
                {
                    newName = projectName.Remove(30, (projectName.Length - 30));
                    newName = newName.Insert(newName.Length, "...");
                    Label.Text = "- " + newName;
                    Label.Name = newName + Project.id;
                } else
                {
                    Label.Text = "- " + projectName;
                    Label.Name = projectName + Project.id;
                }             
                Label.UseMnemonic = true;
                Label.AutoSize = true;
                if (!Project.active)
                {
                    Label.ForeColor = Color.Red;
                }
                Label.Font = new Font("Cambria", 11);
                Label.Location = new Point(1, positionLabel);
                BackColor.Controls.Add(Label);

                // Créer le label
                string projectType = Project.type;
                string newType = "";
                Label LabelType = new Label();
                LabelType.BackColor = Color.Transparent;
                if (projectType.Length > 20)
                {
                    newType = projectType.Remove(20, (projectType.Length - 20));
                    newType = newType.Insert(newType.Length, "...");
                    LabelType.Text = "- " + newType;
                    LabelType.Name = newType + Project.id;
                } else
                {
                    LabelType.Text = "- " + projectType;
                    LabelType.Name = projectType + Project.id;
                }
                LabelType.UseMnemonic = true;
                LabelType.AutoSize = true;
                if (!Project.active)
                {
                    LabelType.ForeColor = Color.Red;
                }
                LabelType.Font = new Font("Cambria", 11);
                LabelType.Location = new Point(200, positionLabel);
                BackColor.Controls.Add(LabelType);

                // Créer Le button
                Button button = new Button();
                button.Name = Project.id.ToString();
                button.Text = "Aller à";
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Gray;
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(400, positionButton);
                button.Click += new EventHandler(goToProject);
                BackColor.Controls.Add(button);

                // Créer la ligne
                LigneHorizontale LigneHorizontale = new LigneHorizontale();
                LigneHorizontale.Name = "Ligne" + Project.id.ToString();
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
        private void goToProject(object sender, EventArgs e)
        {
            Button button = sender as Button;
            main.goToProject(Convert.ToInt32(button.Name));
        }
    }
}
