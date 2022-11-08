using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations.OrganizationListTeam
{
    public partial class MainOrganizationListTeam : UserControl
    {
        public MainOrganizationListTeam(bool archived = false, bool open = true, string name = null, string type = null)
        {
            InitializeComponent();

            OrganizationListTeams ListTeams = new OrganizationListTeams(archived, open, 0, name);
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();

            OrganizationPaginationTeam OrganizationPaginationTeam = new OrganizationPaginationTeam(archived, open, 0, name);
            PanelPagination.Controls.Clear();
            PanelPagination.Controls.Add(OrganizationPaginationTeam);
            OrganizationPaginationTeam.Show();

            PanelPagination.Left = (520 - PanelPagination.Width) / 2;
        }

        public static void goToPaginateTeam(bool archived, bool open, int page, string name)
        {
            OrganizationListTeams ListTeams = new OrganizationListTeams(archived, open, page, name);
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();

            OrganizationPaginationTeam OrganizationPaginationTeam = new OrganizationPaginationTeam(archived, open, page, name);
            PanelPagination.Controls.Clear();
            PanelPagination.Controls.Add(OrganizationPaginationTeam);
            OrganizationPaginationTeam.Show();

            PanelPagination.Left = (520 - PanelPagination.Width) / 2;
        }
    }
}
