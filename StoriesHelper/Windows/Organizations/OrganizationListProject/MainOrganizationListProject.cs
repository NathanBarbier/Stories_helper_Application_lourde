using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations.OrganizationListProject
{
    public partial class MainOrganizationListProject : UserControl
    {
        public MainOrganizationListProject(bool archived = false, bool open = true, string name = null, string type = null)
        {
            InitializeComponent();

            OrganizationListProjects ListProjects = new OrganizationListProjects(archived, open, 0, name, type);
            PanelListProjects.Controls.Clear();
            PanelListProjects.Controls.Add(ListProjects);
            ListProjects.Show();

            OrganizationPaginationProject OrganizationPaginationProject = new OrganizationPaginationProject(archived, open, 0, name, type);
            PanelPagination.Controls.Clear();
            PanelPagination.Controls.Add(OrganizationPaginationProject);
            OrganizationPaginationProject.Show();

            PanelPagination.Left = (520 - PanelPagination.Width) / 2;
        }

        public static void goToPaginateProject(bool archived, bool open, int page, string name, string type)
        {
            OrganizationListProjects ListProjects = new OrganizationListProjects(archived, open, page, name, type);
            PanelListProjects.Controls.Clear();
            PanelListProjects.Controls.Add(ListProjects);
            ListProjects.Show();

            OrganizationPaginationProject OrganizationPaginationProject = new OrganizationPaginationProject(archived, open, page, name, type);
            PanelPagination.Controls.Clear();
            PanelPagination.Controls.Add(OrganizationPaginationProject);
            OrganizationPaginationProject.Show();

            PanelPagination.Left = (520 - PanelPagination.Width) / 2;
        }
    }
}
