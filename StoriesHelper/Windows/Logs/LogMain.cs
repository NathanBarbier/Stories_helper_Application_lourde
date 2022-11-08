using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Logs
{
    public partial class LogMain : UserControl
    {
        protected List<string> ListStatus = new List<string>();
        protected List<string> ListAction = new List<string>();
        protected List<string> ListObjet = new List<string>();
        protected List<string> ListPage = new List<string>();
        public LogMain()
        {
            InitializeComponent();
            LogConsole LogConsoleContent = new LogConsole();

            PanelLogConsole.Controls.Clear();
            PanelLogConsole.Controls.Add(LogConsoleContent);

            LogConsoleContent.Show();

            ListStatus.Add("");
            ListStatus.Add("INFO");
            ListStatus.Add("IMPORTANT");
            ListStatus.Add("WARNING");
            ListStatus.Add("ERROR");

            foreach (string status in ListStatus)
            {
                statusCombo.Items.AddRange(new Object[] { status });
            }

            ListAction.Add("");
            ListAction.Add("create");
            ListAction.Add("update");
            ListAction.Add("delete");
            ListAction.Add("archive");
            ListAction.Add("connect");
            ListAction.Add("assign");
            ListAction.Add("get");

            foreach (string action in ListAction)
            {
                actionCombo.Items.AddRange(new Object[] { action });
            }

            ListObjet.Add("");
            ListObjet.Add("project");
            ListObjet.Add("team");
            ListObjet.Add("column");
            ListObjet.Add("task");
            ListObjet.Add("task_comment");
            ListObjet.Add("organization");
            ListObjet.Add("user");

            foreach (string objet in ListObjet)
            {
                objetCombo.Items.AddRange(new Object[] { objet });
            }

            ListPage.Add("");
            ListPage.Add("/map");
            ListPage.Add("/associateList");
            ListPage.Add("/projectDashboard");
            ListPage.Add("/projectList");
            ListPage.Add("/login");
            ListPage.Add("/organizationDashBoard");
            ListPage.Add("/projectCreation");
            ListPage.Add("/userSignup");
            ListPage.Add("/dashboard");
            ListPage.Add("/passwordUpdate");

            foreach (string page in ListPage)
            {
                pageCombo.Items.AddRange(new Object[] { page });
            }
        }

        private void filtre_Click(object sender, EventArgs e)
        {
            error.Text = "";
            string dateDebutValue = null;
            string dateFinValue = null;
            if (dateDebut.Enabled == true)
            {
                dateDebutValue = dateDebut.Text;
            }
            if (dateDebut.Enabled == true)
            {
                dateFinValue = dateFin.Text;
            }
            string statusValue = statusCombo.Text;
            string actionValue = actionCombo.Text;
            string objetValue = objetCombo.Text;
            string pageValue = pageCombo.Text;
            if (dateDebut.Enabled == true && dateDebut.Enabled == true && DateTime.Parse(dateDebutValue) > DateTime.Parse(dateFinValue)) 
            {
                error.Text = "La date de fin est inférieur à la date de début, veuillez vérifier les informations.";
                return;
            }
            if (!ListStatus.Contains(statusValue))
            {
                error.Text = "Le status renseigné est incorrect, veuillez vérifier les informations.";
                return;
            }
            if (!ListAction.Contains(actionValue))
            {
                error.Text = "L'action renseignée est incorrecte, veuillez vérifier les informations.";
                return;
            }
            if (!ListObjet.Contains(objetValue))
            {
                error.Text = "L'objet renseigné est incorrect, veuillez vérifier les informations.";
                return;
            }
            if (!ListPage.Contains(pageValue))
            {
                error.Text = "La page renseignée est incorrecte, veuillez vérifier les informations.";
                return;
            }


            LogConsole LogConsoleContent = new LogConsole(dateDebutValue, dateFinValue, statusValue, actionValue, objetValue, pageValue);

            PanelLogConsole.Controls.Clear();
            PanelLogConsole.Controls.Add(LogConsoleContent);

            LogConsoleContent.Show();
        }

        private void allowDateDebut_CheckedChanged(object sender, EventArgs e)
        {
            if (allowDateDebut.Checked == true)
            {
                dateDebut.Enabled = true;
            } else
            {
                dateDebut.Enabled = false;
            }
        }

        private void allowDateFin_CheckedChanged(object sender, EventArgs e)
        {
            if (allowDateFin.Checked == true)
            {
                dateFin.Enabled = true;
            }
            else
            {
                dateFin.Enabled = false;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            allowDateDebut.CheckState = CheckState.Unchecked;
            allowDateFin.CheckState = CheckState.Unchecked;
            statusCombo.Text = "";
            actionCombo.Text = "";
            objetCombo.Text = "";
            pageCombo.Text = "";

            LogConsole LogConsoleContent = new LogConsole();

            PanelLogConsole.Controls.Clear();
            PanelLogConsole.Controls.Add(LogConsoleContent);

            LogConsoleContent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogStatistique LogStatistique = new LogStatistique();

            LogStatistique.Show();
        }
    }
}
