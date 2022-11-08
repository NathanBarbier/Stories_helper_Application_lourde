using System;
using System.Windows.Forms;
using StoriesHelper.Services;
using StoriesHelper.Models;
using System.Collections.Generic;
using System.Drawing;
using StoriesHelper.Repository;
using StoriesHelper.Models;
using System.Linq;

namespace StoriesHelper.Windows.Logs
{
    public partial class LogConsole : UserControl
    {
        protected string dateDebutValue;
        protected string dateFinValue;
        protected string statusValue;
        protected string idValue;
        protected string actionValue;
        protected string objetValue;
        protected string pageValue;
        public LogConsole(string dateDebutValue = null, string dateFinValue = null, string statusValue = null, string actionValue = null, string objetValue = null, string pageValue = null)
        {
            InitializeComponent();

            // Display 100 logs in the console log
            LogHistoryRepository logHistoryRepository = new LogHistoryRepository();
            List<LogHistory> logs = logHistoryRepository.GetLogsByOrganization(Session.UserId, dateDebutValue, dateFinValue, statusValue, actionValue, objetValue, pageValue);
            logs = logs.OrderBy(dc => dc.getDate_creation()).ToList();
            RichTextBox Line = new RichTextBox();
            Line.Size = new Size(1080, 640);
            Line.Multiline = true;
            Line.MaxLength = 2147483647;
            Line.Location = new Point(10, 5);
            Line.BackColor = Color.Black;
            Line.BorderStyle = BorderStyle.None;
            Line.ReadOnly = true;
            foreach (LogHistory log in logs)
            {
                string date = log.getDate_creation().ToString("yyyy MMM dd HH:mm:ss");
                /*                string ip = "[" + log.getIp().ToString() + "]";*/
                User User = new User(log.getFk_author());
                string auteur = User.getRowId().ToString();
                if (User.getLastname() == null && User.getFirstname() == null)
                {
                    auteur = "ADMIN";
                }
                else
                {
                    auteur = User.getLastname() + " " + User.getFirstname();
                }
                string action = log.getAction();
                string objectName = log.getObject();
                string status = "[" + log.getStatus() + "]";
                string exception = log.getException();

                // On affiche la liste des logs

                rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, date, Line); // la date
                Line.AppendText(" ");
                if (log.getIp() != null) { 
                    rtb_AppendText(new Font("Cambria", 12), Color.Gray, Color.Black, log.getIp(), Line); // l'ip
                }
                Line.AppendText(" ");
                switch (status) // le status
                {
                    case "[INFO]":
                        rtb_AppendText(new Font("Cambria", 12, FontStyle.Bold), Color.DodgerBlue, Color.Black, status, Line);
                        break;
                    case "[WARNING]":
                        rtb_AppendText(new Font("Cambria", 12, FontStyle.Bold), Color.Yellow, Color.Black, status, Line);
                        break;
                    case "[ERROR]":
                        rtb_AppendText(new Font("Cambria", 12, FontStyle.Bold), Color.Red, Color.Black, status, Line);
                        break;
                    case "[IMPORTANT]":
                        rtb_AppendText(new Font("Cambria", 12, FontStyle.Bold), Color.Orange, Color.Black, status, Line);
                        break;
                }
                this.Controls.Add(Line);
                rtb_AppendText(new Font("Cambria", 12), Color.Green, Color.Black, "[" + User.getRowId().ToString() + "] ", Line); // id de l'utilisateur qui a fait l'action
                rtb_AppendText(new Font("Cambria", 12), Color.Green, Color.Black, auteur, Line); // le nom et prémon de l'utilisateur qui afait l'action. Si vide ADMIN est écrit
                Line.AppendText(" "); 
                rtb_AppendText(new Font("Cambria", 12), Color.Orange , Color.Black, action, Line); // l'action effectuée
                Line.AppendText(" ");
                rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, objectName, Line); // l'objet dont il est question (projet, team, task ...)
                Line.AppendText(" ");
                if (log.getObject_name() != null) // name de l'objet si non null
                {
                    rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, "`" + log.getObject_name() + "`", Line);
                    Line.AppendText(" ");
                }
                if (log.getObject_id() != null) // id de l'objet si non null
                {
                    rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, "[" + log.getObject_id() + "]", Line);
                    Line.AppendText(" ");
                }
                if (log.getObject_parent() != null) // l'objet parent si non null
                {
                    rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, "from " + log.getObject_parent(), Line);
                    Line.AppendText(" ");
                }
                if (log.getObject_parent_name() != null) // l'objet parent si non null
                {
                    rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, "`" + log.getObject_parent_name() + "`", Line);
                    Line.AppendText(" ");
                }
                if (log.getObject_parent_id() != null) // l'objet parent si non null
                {
                    rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, "[" + log.getObject_parent_id() + "]", Line);
                    Line.AppendText(" ");
                }
                if (status == "[ERROR]") { // si Error on affiche l'exception
                    rtb_AppendText(new Font("Cambria", 12), Color.Red, Color.Black, "Create an error : " + exception, Line);
                }
                rtb_AppendText(new Font("Cambria", 12), Color.Gray, Color.Black, "on page " + log.getPage(), Line); // la page
                Line.AppendText(" ");

                Line.AppendText("\n");

            }
            Line.ScrollToCaret();
        }

        private void rtb_AppendText(Font selfont, Color color, Color bcolor, string text, RichTextBox Rtb)

        {
            //append the text to the RichTextBox control
            int start = Rtb.TextLength;
            Rtb.AppendText(text);
            int end = Rtb.TextLength;
            //select the new text
            Rtb.Select(start, end - start);
            //set the attributes of the new text
            Rtb.SelectionColor = color;
            Rtb.SelectionFont = selfont;
            Rtb.SelectionBackColor = bcolor;
            //unselect
            Rtb.Select(end, 0);
        }
        
    }
}