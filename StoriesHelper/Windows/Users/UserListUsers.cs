using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Services;
using StoriesHelper.Repository;

namespace StoriesHelper.Windows.Users
{
    public partial class UserListUsers : UserControl
    {
        UserRepository UserRepository = new UserRepository();
        protected string lastname;
        protected string firstname;
        protected string email;
        protected string team;
        protected string project;
        protected string id;
        public UserListUsers(string lastname = null, string firstname = null, string email = null, string team = null, string project = null, string id = null, int page = 0)
        {
            InitializeComponent();

            this.lastname = lastname != "" || lastname != null ? lastname : null;
            this.firstname = firstname != "" || firstname != null ? firstname : null;
            this.email = email != "" || email != null ? email : null;
            this.team = team != "" || team != null ? team : null;
            this.project = project != "" || project != null ? project : null;
            this.id = id != "" || id != null ? id : null;

            List<UserList> CollaboratorsList = new List<UserList>();
            List<UserList> Collaborators = new List<UserList>();

            CollaboratorsList = UserRepository.getUserFromOrganization(Session.UserId, lastname, firstname, email, team, project, id, page);

            int delta = 0;
            CollaboratorsList = CollaboratorsList.OrderBy(c => c.rowid).ToList();
            foreach (UserList Collaborator in CollaboratorsList)
            {
                if(Collaborator.rowid != delta)
                {
                    Collaborators.Add(Collaborator);
                }
                delta = Collaborator.rowid;
            }

            int positionLabel = 20;
            int positionButton = 15;
            int positionLigne = 60;

            foreach (UserList Collaborator in Collaborators)
            {
                // Créer le label Id 
                string userId = Collaborator.rowid.ToString();
                string newId = "";
                Label LabelId = new Label();
                if (userId.Length > 6)
                {
                    newId = userId.Remove(6, (userId.Length - 6));
                    newId = newId.Insert(newId.Length, ".");
                    LabelId.Text = "#" + newId;
                    LabelId.Name = LabelId.Text + Collaborator.rowid;
                }
                else
                {
                    LabelId.Text = "#" + userId;
                    LabelId.Name = LabelId.Text + Collaborator.rowid;
                }
                LabelId.UseMnemonic = true;
                LabelId.AutoSize = true;
                LabelId.Font = new Font("Cambria", 14);
                LabelId.Location = new Point(0, positionLabel);
                this.Controls.Add(LabelId);

                // Créer le label Lastname
                string UserLastname = Collaborator.lastname.ToUpper();
                string newLastname = "";
                Label LabelLastname = new Label();
                if (UserLastname.Length > 15)
                {
                    newLastname = UserLastname.Remove(15, (UserLastname.Length - 15));
                    newLastname = newLastname.Insert(newLastname.Length, "...");
                    LabelLastname.Text = newLastname;
                    LabelLastname.Name = newLastname + Collaborator.rowid;
                }
                else
                {
                    LabelLastname.Text = UserLastname;
                    LabelLastname.Name = UserLastname + Collaborator.rowid;
                }
                LabelLastname.UseMnemonic = true;
                LabelLastname.AutoSize = true;
                LabelLastname.Font = new Font("Cambria", 14);
                LabelLastname.Location = new Point(90, positionLabel);
                this.Controls.Add(LabelLastname);

                // Créer le label Firstname
                string UserFirstname = Collaborator.firstname;
                string newFirstname = "";
                Label LabelFirstname = new Label();
                if (UserFirstname.Length > 10)
                {
                    newFirstname = UserFirstname.Remove(10, (UserFirstname.Length - 10));
                    newFirstname = newFirstname.Insert(newFirstname.Length, "...");
                    LabelFirstname.Text = newFirstname;
                    LabelFirstname.Name = newFirstname + Collaborator.rowid;
                }
                else
                {
                    LabelFirstname.Text = UserFirstname;
                    LabelFirstname.Name = UserFirstname + Collaborator.rowid;
                }
                LabelFirstname.UseMnemonic = true;
                LabelFirstname.AutoSize = true;
                LabelFirstname.Font = new Font("Cambria", 14);
                LabelFirstname.Location = new Point(230, positionLabel);
                this.Controls.Add(LabelFirstname);

                // Créer le label Email
                string UserEmail = Collaborator.email;
                string newLabelEmail = "";
                Label LabelEmail = new Label();
                if (UserEmail.Length > 25)
                {
                    newLabelEmail = UserEmail.Remove(25, (UserEmail.Length - 25));
                    newLabelEmail = newLabelEmail.Insert(newLabelEmail.Length, "...");
                    LabelEmail.Text = newLabelEmail;
                    LabelEmail.Name = newLabelEmail + Collaborator.rowid;
                }
                else
                {
                    LabelEmail.Text = UserEmail;
                    LabelEmail.Name = UserEmail + Collaborator.rowid;
                }
                LabelEmail.UseMnemonic = true;
                LabelEmail.AutoSize = true;
                LabelEmail.Font = new Font("Cambria", 13);
                LabelEmail.Location = new Point(340, positionLabel);
                this.Controls.Add(LabelEmail);

                // Créer le combo Team
                ComboBox ComboTeam = new ComboBox();
                ComboTeam.Name = "Team" + Collaborator.rowid;
                foreach (string Team in Collaborator.TeamsName)
                {
                    string LabelTeam = Team;
                    string newLabelTeam = "";
                    if (LabelTeam.Length > 15)
                    {
                        newLabelTeam = LabelTeam.Remove(15, (LabelTeam.Length - 15));
                        newLabelTeam = newLabelTeam.Insert(newLabelTeam.Length, "...");
                        ComboTeam.Items.AddRange(new Object[] { newLabelTeam });
                    }
                    else
                    {
                        ComboTeam.Items.AddRange(new Object[] { LabelTeam });
                    }
                }
                ComboTeam.Font = new Font("Cambria", 14);
                ComboTeam.Width = 150;
                ComboTeam.Location = new Point(600, positionLabel);
                this.Controls.Add(ComboTeam);

                // Créer le combo Projet

                ComboBox ComboProject = new ComboBox();
                ComboProject.Name = "Team" + Collaborator.rowid;
                foreach (string Project in Collaborator.ProjectsName)
                {
                    string LabelProject = Project;
                    string newLabelProject = "";
                    if (LabelProject.Length > 15)
                    {
                        newLabelProject = LabelProject.Remove(15, (LabelProject.Length - 15));
                        newLabelProject = newLabelProject.Insert(newLabelProject.Length, "...");
                        ComboProject.Items.AddRange(new Object[] { newLabelProject });
                    } else
                    {
                        ComboProject.Items.AddRange(new Object[] { LabelProject });
                    }
                }
                ComboProject.Font = new Font("Cambria", 14);
                ComboProject.Width = 150;
                ComboProject.Location = new Point(770, positionLabel);
                this.Controls.Add(ComboProject);

                // Créer Le button
                Button button = new Button();
                button.Name = Collaborator.rowid.ToString();
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 14);
                button.Size = new Size(108, 33);
                button.Location = new Point(930, positionButton);
                button.Click += new EventHandler(goToUser);
                this.Controls.Add(button);

                // Créer la ligne
                LigneHorizontale LigneHorizontale = new LigneHorizontale();
                LigneHorizontale.Name = "Ligne" + Collaborator.rowid.ToString();
                LigneHorizontale.Location = new Point(0, positionLigne);
                LigneHorizontale.Width = 1050;
                LigneHorizontale.Height = 1;
                this.Controls.Add(LigneHorizontale);


                positionLabel += 60;
                positionButton += 60;
                positionLigne += 60;
            }
        }

        private void goToUser(object sender, EventArgs e)
        {
            Button button = sender as Button;

            UserInterface.UserInterface UserInterface = new UserInterface.UserInterface(Int32.Parse(button.Name));

            UserInterface.Show();
        }
    }
}
