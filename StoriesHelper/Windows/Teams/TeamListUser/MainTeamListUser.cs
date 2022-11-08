using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Teams.TeamListUser
{
    public partial class MainTeamListUser : UserControl
    {
        public MainTeamListUser(int idTeam, string lastname = null, string firstname = null, string email = null)
        {
            InitializeComponent();

            TeamListUsers TeamListUsers = new TeamListUsers(idTeam, lastname, firstname, email);
            PanelListUsers.Controls.Clear();
            PanelListUsers.Controls.Add(TeamListUsers);
            TeamListUsers.Show();

            TeamPaginationUser TeamPaginationUser = new TeamPaginationUser(idTeam, lastname, firstname, email, 0);
            PanelPagination.Controls.Clear();
            PanelPagination.Controls.Add(TeamPaginationUser);
            TeamPaginationUser.Show();

            PanelPagination.Left = (this.ClientSize.Width - PanelPagination.Width) / 2;
        }

        public static void goToPaginateTeam(int idTeam, string lastname, string firstname, string email, int page = 0)
        {
            TeamListUsers TeamListUsers = new TeamListUsers(idTeam, lastname, firstname, email, page);
            PanelListUsers.Controls.Clear();
            PanelListUsers.Controls.Add(TeamListUsers);
            TeamListUsers.Show();

            TeamPaginationUser TeamPaginationUser = new TeamPaginationUser(idTeam, lastname, firstname, email, page);
            PanelPagination.Controls.Clear();
            PanelPagination.Controls.Add(TeamPaginationUser);
            TeamPaginationUser.Show();

            PanelPagination.Left = (575 - PanelPagination.Width) / 2;
        }
    }
}
