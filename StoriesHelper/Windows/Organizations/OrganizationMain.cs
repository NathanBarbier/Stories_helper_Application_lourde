using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Services;
using StoriesHelper.Windows.Organizations.OrganizationListProject;
using StoriesHelper.Windows.Organizations.OrganizationListTeam;
using StoriesHelper.Windows.Organizations.Icons;

namespace StoriesHelper.Windows.Organizations
{
    public partial class OrganizationMain : UserControl
    {
        protected string projectName = "";
        protected string projectType = "";
        protected string teamName = "";
        public OrganizationMain(string projectName = "", string projectType = "")
        {
            // Header
            int idOrganization = Session.UserId;
            InitializeComponent();
            Gradient GradientTitre = new Gradient();
            GradientTitre.Name = "GradientTitre";
            GradientTitre.Size = new Size(1100, 60);
            GradientTitre.BackColor = Color.FromArgb(200, 30, 137, 255);
            GradientTitre.Location = new Point(0, 0);
            gradient.Controls.Add(GradientTitre);

            LigneHorizontale LigneTitre = new LigneHorizontale();
            LigneTitre.Name = "LigneTitre";
            LigneTitre.Location = new Point(0, 59);
            LigneTitre.Width = 1100;
            LigneTitre.Height = 1;
            GradientTitre.Controls.Add(LigneTitre);

            Organization Organization = new Organization(idOrganization);

            OrganizationLabel.Text += Organization.getName();
            GradientTitre.Controls.Add(OrganizationLabel);
            OrganizationLabel.Left = (1100 - OrganizationLabel.Width) / 2;
            OrganizationLabel.Top = (60 - OrganizationLabel.Height) / 2;

            // fin Header

            List<Project> Projects = Organization.getListProjects();
            List<Team> Teams = new List<Team>();
            List<Column> Columns = new List<Column>();
            List<Task> Tasks = new List<Task>();
            List<Task> TasksClosed = new List<Task>();
            List<Task> TasksOpen = new List<Task>();
            List<User> Users = Organization.getListUsers();
            int nbArchived = 0;
            int nbProjects = 0;
            foreach (Project project in Projects)
            {
                Teams.AddRange(project.getListTeams());

                if (!project.isActive())
                {
                    nbArchived++;
                } else
                {
                    nbProjects++;
                }
            }

            foreach (Team team in Teams)
            {
                Columns.AddRange(team.getListColumns());
            }
            foreach (Column Column in Columns)
            {
                foreach (Task task in Column.getListTasks())
                {
                    if (task.isActive() != 0)
                    {
                        if (Column.getName() == "Closed")
                        {
                            TasksClosed.Add(task);
                        }
                        else
                        {
                            TasksOpen.Add(task);
                        }
                        Tasks.Add(task);
                    }
                }
            }
            int nbTeams = Teams.Count();
            int nbUsers = Users.Count();

            displayTaskChart(Tasks, TasksOpen, TasksClosed);

            // icone Utilisateur
            IconUser IconUser = new IconUser();
            panelIconUser.Controls.Clear();
            panelIconUser.Controls.Add(IconUser);
            IconUser.Show();

            // icone Equipe
            IconTeam IconTeam = new IconTeam();
            panelIconTeam.Controls.Clear();
            panelIconTeam.Controls.Add(IconTeam);
            IconTeam.Show();

            // icone Projet
            IconProject IconProject = new IconProject();
            panelIconProject.Controls.Clear();
            panelIconProject.Controls.Add(IconProject);
            IconProject.Show();

            // Liste Projets
            MainOrganizationListProject MainOrganizationListProject = new MainOrganizationListProject();
            PanelListProjects.Controls.Clear();
            PanelListProjects.Controls.Add(MainOrganizationListProject);
            MainOrganizationListProject.Show();

            // Liste Teams
            MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam();
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(MainOrganizationListTeam);
            MainOrganizationListTeam.Show();
        }

        private void FilterDisplayProject(object sender, System.EventArgs e)
        {
            projectName = FilterNameProject.Text;
            projectType = FilterTypeProject.Text;

            showListProject();
        }

        private void displayProject(object sender, System.EventArgs e)
        {
            showListProject();
        }
        
        private void FilterDisplayTeam(object sender, System.EventArgs e)
        {
            teamName = FilterNameTeam.Text;

            showListTeam();
        }

        private void displayTeam(object sender, System.EventArgs e)
        {
            showListTeam();
        }

        private void displayTaskChart(List<Task> Tasks, List<Task> TasksOpen, List<Task> TasksClosed)
        {

            if (TasksClosed.Count() == 0 && TasksOpen.Count() == 0)
            {
                GraphiqueRatioTaskOrganization.Series["Task"].Points.AddXY("no Data", 1);
            }
            else
            {
                double ratioOpen = Calcul.CalculateRatioTasks(TasksOpen.Count(), Tasks.Count());
                double ratioClosed = Calcul.CalculateRatioTasks(TasksClosed.Count(), Tasks.Count());
                string labelOpen = "En cours (" + ratioOpen + "%)";
                string labelClosed = "Terminées (" + ratioClosed + "%)";

                GraphiqueRatioTaskOrganization.Series["Task"].IsValueShownAsLabel = true;
                GraphiqueRatioTaskOrganization.Series["Task"].Points.AddXY(labelOpen, TasksOpen.Count());
                GraphiqueRatioTaskOrganization.Series["Task"].Points.AddXY(labelClosed, TasksClosed.Count());
            }
        }
        
        public void showListProject()
        {
            if (checkBoxArchivedProject.Checked && checkBoxOpenProject.Checked)
            {
                MainOrganizationListProject ListProjects = new MainOrganizationListProject(true, true, projectName, projectType);
                PanelListProjects.Controls.Clear();
                PanelListProjects.Controls.Add(ListProjects);
                ListProjects.Show();
            }
            else if (checkBoxArchivedProject.Checked && !checkBoxOpenProject.Checked)
            {
                MainOrganizationListProject ListProjects = new MainOrganizationListProject(true, false, projectName, projectType);
                PanelListProjects.Controls.Clear();
                PanelListProjects.Controls.Add(ListProjects);
            }
            else if (!checkBoxArchivedProject.Checked && !checkBoxOpenProject.Checked)
            {
                MainOrganizationListProject ListProjects = new MainOrganizationListProject(false, false, projectName, projectType);
                PanelListProjects.Controls.Clear();
                PanelListProjects.Controls.Add(ListProjects);
                ListProjects.Show();
            }
            else
            {
                MainOrganizationListProject ListProjects = new MainOrganizationListProject(false, true, projectName, projectType);
                PanelListProjects.Controls.Clear();
                PanelListProjects.Controls.Add(ListProjects);
                ListProjects.Show();
            }
        }

        public void showListTeam()
        {
            if (checkBoxArchivedTeam.Checked && checkBoxOpenTeam.Checked)
            {
                MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam(true, true, teamName);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(MainOrganizationListTeam);
                MainOrganizationListTeam.Show();
            }
            else if (checkBoxArchivedTeam.Checked && !checkBoxOpenTeam.Checked)
            {
                MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam(true, false, teamName);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(MainOrganizationListTeam);
                MainOrganizationListTeam.Show();
            }
            else if (!checkBoxArchivedTeam.Checked && !checkBoxOpenTeam.Checked)
            {
                MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam(false, false, teamName);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(MainOrganizationListTeam);
                MainOrganizationListTeam.Show();
            }
            else
            {
                MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam(false, true, teamName);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(MainOrganizationListTeam);
                MainOrganizationListTeam.Show();
            }
        }
    }
}
