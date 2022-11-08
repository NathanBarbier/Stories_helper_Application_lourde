using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Repository;
using StoriesHelper.Services;

namespace StoriesHelper.Windows.Users
{
    public partial class UserMainList : UserControl
    {
        public UserMainList()
        {
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

            GradientTitre.Controls.Add(UserTitre);
            UserTitre.Left = (1100 - UserTitre.Width) / 2;
            UserTitre.Top = (60 - UserTitre.Height) / 2;

            ProjectRepository ProjectRepository = new ProjectRepository();
            TeamRepository TeamRepository = new TeamRepository();

            List<ProjectNameType> ProjectList = ProjectRepository.GetProjectsByOrganization(Session.UserId);
            List<TeamNameType> TeamList = TeamRepository.GetTeamsByOrganization(Session.UserId);

            this.comboTeam.DropDownWidth = 200;
            this.comboProject.DropDownWidth = 200;
            foreach (ProjectNameType Project in ProjectList)
            {
                this.comboProject.Items.AddRange(new Object[] { Project.name });
            }
            foreach (TeamNameType Team in TeamList)
            {
                this.comboTeam.Items.AddRange(new Object[] { Team.name });
            }

            // Affichage de la liste
            UserListUsers UserListUsers = new UserListUsers();

            panelListUsers.Controls.Clear();
            panelListUsers.Controls.Add(UserListUsers);

            UserListUsers.Show();

            UserPaginationUsers UserPaginationUsers = new UserPaginationUsers();

            panelPagination.Controls.Clear();
            panelPagination.Controls.Add(UserPaginationUsers);

            UserPaginationUsers.Show();

            panelPagination.Left = (1081 - panelPagination.Width) / 2;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string lastname = textName.Text;
            string firstname = textFirstname.Text;
            string email = textEmail.Text;
            string team = comboTeam.Text;
            string project = comboProject.Text;
            string id = textId.Text;

            UserListUsers UserListUsers = new UserListUsers(lastname, firstname, email, team, project, id);

            panelListUsers.Controls.Clear();
            panelListUsers.Controls.Add(UserListUsers);

            UserListUsers.Show();

            UserPaginationUsers UserPaginationUsers = new UserPaginationUsers();

            panelPagination.Controls.Clear();
            panelPagination.Controls.Add(UserPaginationUsers);

            UserPaginationUsers.Show();

            panelPagination.Left = (1081 - panelPagination.Width) / 2;
        }

        public static void goToPaginateUser(string lastname = null, string firstname = null, string email = null, string team = null, string project = null, string id = null, int page = 0)
        {
            UserListUsers UserListUsers = new UserListUsers(lastname, firstname, email, team, project, id, page);

            panelListUsers.Controls.Clear();
            panelListUsers.Controls.Add(UserListUsers);

            UserListUsers.Show();

            UserPaginationUsers UserPaginationUsers = new UserPaginationUsers(lastname, firstname, email, team, project, id, page);

            panelPagination.Controls.Clear();
            panelPagination.Controls.Add(UserPaginationUsers);

            UserPaginationUsers.Show();

            panelPagination.Left = (1081 - panelPagination.Width) / 2;
        }
    }
}
