using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Projects.ProjectListTeam
{
    public partial class MainProjectListTeam : UserControl
    {
        public MainProjectListTeam(int idProject, string name = null, string type = null)
        {
            InitializeComponent();

            ProjectListTeams ListTeams = new ProjectListTeams(idProject, 0, name);
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();

            ProjectPaginationTeam ProjectPaginationTeam = new ProjectPaginationTeam(idProject, 0, name);
            PanelPagination.Controls.Clear();
            PanelPagination.Controls.Add(ProjectPaginationTeam);
            ProjectPaginationTeam.Show();

            PanelPagination.Left = (this.ClientSize.Width - PanelPagination.Width) / 2;
        }

        public static void goToPaginateTeam(int idProject, int page, string name)
        {
            ProjectListTeams ListTeams = new ProjectListTeams(idProject, page, name);
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();

            ProjectPaginationTeam OrganizationPaginationTeam = new ProjectPaginationTeam(idProject, page, name);
            PanelPagination.Controls.Clear();
            PanelPagination.Controls.Add(OrganizationPaginationTeam);
            OrganizationPaginationTeam.Show();

            PanelPagination.Left = (625 - PanelPagination.Width) / 2;
        }
    }
}
