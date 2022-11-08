using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StoriesHelper.Services;
using StoriesHelper.Models;

namespace StoriesHelper.Windows
{
    using BCrypt.Net;

    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("database=storieshelper;server=localhost;user id = root;pwd=");
        public Login()
        {
            InitializeComponent();
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string mdp = passwordInput.Text;
            string email = emailInput.Text;
            command.Parameters.AddWithValue("@email", email);
            command.CommandText = "SELECT rowid, email, password, fk_organization FROM storieshelper_user WHERE email = @email AND admin = 1";
            MySqlDataReader reader = command.ExecuteReader();
            string mdpHash = "";
            int idOrganization = 0;
            if (reader.HasRows)
            {
                erreur.Text = "";
                while (reader.Read())
                {
                    mdpHash = reader.GetString(2);
                    idOrganization = reader.GetInt32(3);
                }

                if (BCrypt.Verify(mdp, mdpHash))
                {

                    Session.UserId = idOrganization;
                    main WelcomeWindow = new main();

                    WelcomeWindow.Show();
                    this.Hide();
                }
                else
                {
                    erreur.Text = "*L'une des informations est incorrecte";
                }
            }
            else
            {
                erreur.Text = "*L'une des informations est incorrecte";
            }
            erreur.Left = (this.ClientSize.Width - erreur.Width) / 2;
            conn.Close();
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MyDraggableForm mdf = new MyDraggableForm();
            mdf.Drag(sender, e, Handle);
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.connexion_Click(sender, e);
            }
        }
    }
}