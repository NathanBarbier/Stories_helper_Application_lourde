using StoriesHelper.Services;
using StoriesHelper.Repository;
using System;
using System.Collections.Generic;
using StoriesHelper.Models;
using StoriesHelper.Windows.Users.UserInterface;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Teams.TeamListUser
{
    public partial class TeamListUsers : UserControl
    {
        protected int idTeam;
        public TeamListUsers(int idTeam, string lastname = null, string firstname = null, string email = null, int page = 0)
        {
            InitializeComponent();
            this.idTeam = idTeam;
            UserRepository UserRepository = new UserRepository();
            List<User> Users = UserRepository.getUserFromTeam(idTeam, lastname, firstname, email, page);

            int positionLabel = 10;
            int positionButton = 7;
            int positionBackColor = 0;
            int rang = 0;
            foreach (User User in Users)
            {
                // créer le fond coloré.
                Gradient BackColor = new Gradient();
                BackColor.Name = "BackColor" + User.getRowId().ToString();
                BackColor.Location = new Point(1, positionBackColor);
                BackColor.Size = new Size(548, 40);
                if (rang % 2 == 0)
                {
                    BackColor.BackColor = Color.FromArgb(66, 0, 0, 0);
                }
                else
                {
                    BackColor.BackColor = Color.FromArgb(33, 0, 0, 0);
                }
                this.Controls.Add(BackColor);

                // Créer le label Lastname
                string UserLastname = User.getLastname().ToUpper();
                string newLastname = "";
                Label LabelLastname = new Label();
                if (UserLastname.Length > 20)
                {
                    newLastname = UserLastname.Remove(20, (UserLastname.Length - 20));
                    newLastname = newLastname.Insert(newLastname.Length, "...");
                    LabelLastname.Text = "- " + newLastname;
                    LabelLastname.Name = newLastname + User.getRowId();
                }
                else
                {
                    LabelLastname.Text = "- " + UserLastname;
                    LabelLastname.Name = UserLastname + User.getRowId();
                }
                LabelLastname.BackColor = Color.Transparent;
                LabelLastname.UseMnemonic = true;
                LabelLastname.AutoSize = true;
                LabelLastname.Font = new Font("Cambria", 11);
                LabelLastname.Location = new Point(0, positionLabel);
                BackColor.Controls.Add(LabelLastname);

                // Créer le label Firstname
                string UserFirstname = User.getFirstname();
                string newFirstname = "";
                Label LabelFirstname = new Label();
                if (UserFirstname.Length > 20)
                {
                    newFirstname = UserFirstname.Remove(20, (UserFirstname.Length - 20));
                    newFirstname = newFirstname.Insert(newFirstname.Length, "...");
                    LabelFirstname.Text = newFirstname;
                    LabelFirstname.Name = newFirstname + User.getRowId();
                }
                else
                {
                    LabelFirstname.Text = UserFirstname;
                    LabelFirstname.Name = UserFirstname + User.getRowId();
                }
                LabelFirstname.BackColor = Color.Transparent;
                LabelFirstname.UseMnemonic = true;
                LabelFirstname.AutoSize = true;
                LabelFirstname.Font = new Font("Cambria", 11);
                LabelFirstname.Location = new Point(130, positionLabel);
                BackColor.Controls.Add(LabelFirstname);

                // Créer le label Email
                string UserEmail = User.getEmail();
                string newLabelEmail = "";
                Label LabelEmail = new Label();
                if (UserEmail.Length > 28)
                {
                    newLabelEmail = UserEmail.Remove(25, (UserEmail.Length - 25));
                    newLabelEmail = newLabelEmail.Insert(newLabelEmail.Length, "...");
                    LabelEmail.Text = newLabelEmail;
                    LabelEmail.Name = newLabelEmail + User.getRowId();
                }
                else
                {
                    LabelEmail.Text = UserEmail;
                    LabelEmail.Name = UserEmail + User.getRowId();
                }
                LabelEmail.BackColor = Color.Transparent;
                LabelEmail.UseMnemonic = true;
                LabelEmail.AutoSize = true;
                LabelEmail.Font = new Font("Cambria", 11);
                LabelEmail.Location = new Point(270, positionLabel);
                BackColor.Controls.Add(LabelEmail);

                // Créer Le button
                Button button = new Button();
                button.Name = User.getRowId().ToString();
                button.BackColor = Color.Transparent;
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(475, positionButton);
                button.Click += new EventHandler(goToUser);
                BackColor.Controls.Add(button);

                positionBackColor += 40;

                // Créer la ligne
                LigneHorizontale LigneHorizontale = new LigneHorizontale();
                LigneHorizontale.Name = "Ligne" + User.getRowId().ToString();
                LigneHorizontale.Location = new Point(0, 0);
                LigneHorizontale.Width = 550;
                LigneHorizontale.Height = 1;
                BackColor.Controls.Add(LigneHorizontale);

                // Créer la ligne
                LigneHorizontale LastLigneHorizontale = new LigneHorizontale();
                LastLigneHorizontale.Name = "LigneHorizontale";
                LastLigneHorizontale.Location = new Point(0, positionBackColor);
                LastLigneHorizontale.Width = 550;
                LastLigneHorizontale.Height = 1;
                Controls.Add(LastLigneHorizontale);
                rang += 1;
            }

            LigneVerticale LeftLigneVerticale = new LigneVerticale();
            LeftLigneVerticale.Name = "LigneVerticale";
            LeftLigneVerticale.Location = new Point(0, 0);
            LeftLigneVerticale.Width = 1;
            LeftLigneVerticale.Height = positionBackColor;
            Controls.Add(LeftLigneVerticale);

            LigneVerticale RightLigneVerticale = new LigneVerticale();
            RightLigneVerticale.Name = "LigneVerticale";
            RightLigneVerticale.Location = new Point(549, 0);
            RightLigneVerticale.Width = 1;
            RightLigneVerticale.Height = positionBackColor;
            Controls.Add(RightLigneVerticale);
        }
        private void goToUser(object sender, EventArgs e)
        {
            Button button = sender as Button;

            UserInterface UserInterface = new UserInterface(Int32.Parse(button.Name));

            UserInterface.Show();
        }
    }
}

