using System;
using System.Drawing;
using System.Windows.Forms;
using StoriesHelper.Services;
using StoriesHelper.Windows.Logs;
using StoriesHelper.Windows.Organizations;
using StoriesHelper.Windows.Projects;
using StoriesHelper.Windows.Teams;
using StoriesHelper.Windows.Users;
using StoriesHelper.Windows.Users.UserInterface;

namespace StoriesHelper.Windows
{
    public partial class main : MyDraggableForm
    {
        public static Panel MainPanel;
        public main()
        {
            InitializeComponent();
            MainPanel = new Panel();
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Location = new Point(299, 0);
            MainPanel.Margin = new Padding(2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1101, 900);
            MainPanel.TabIndex = 3;
            MainPanel.MouseDown += new MouseEventHandler(Form1_MouseDown);
            Controls.Add(MainPanel);
            MinimumSize = new Size(1167, 718);

            OrganizationMain OrganizationContent = new OrganizationMain();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(OrganizationContent);

            OrganizationContent.Show();
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = SystemColors.ControlDarkDark;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void organisationButton_Click(object sender, EventArgs e)
        {
            OrganizationMain OrganizationContent = new OrganizationMain();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(OrganizationContent);

            OrganizationContent.Show();
        }
        private void LogButton_Click(object sender, EventArgs e)
        {
            LogMain LogContent = new LogMain();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(LogContent);

            LogContent.Show();
        }

        static public void goToOrganization()
        {
            OrganizationMain OrganizationContent = new OrganizationMain();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(OrganizationContent);

            OrganizationContent.Show();
        }

        private void collaboratorsButton_Click(object sender, EventArgs e)
        {
            UserMainList UserMainList = new UserMainList();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(UserMainList);

            UserMainList.Show();
        }

        static public void goToProject(int idProject)
        {
            ProjectMain ProjectContent = new ProjectMain(idProject);

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ProjectContent);

            ProjectContent.Show();
        }

        static public void goToTeam(int idTeam, string from)
        {
            TeamMain TeamContent = new TeamMain(idTeam, from);

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(TeamContent);

            TeamContent.Show();
        }

        static public void goToListUser()
        {
            UserMainList UserMainList = new UserMainList();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(UserMainList);

            UserMainList.Show();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Quitter quitter = new Quitter();
            quitter.Show();
        }

        protected void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MyDraggableForm mdf = new MyDraggableForm();
            mdf.Drag(sender, e, Handle);
        }

        private void Disconnect_button_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            Hide();
        }
    }
}
