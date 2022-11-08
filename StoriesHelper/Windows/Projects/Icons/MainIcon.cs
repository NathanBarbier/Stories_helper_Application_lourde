using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoriesHelper.Models;

namespace StoriesHelper.Windows.Projects.Icons
{
    public partial class MainIcon : UserControl
    {
        public MainIcon(string type, string date, int NbUser, int NbTeam, string description)
        {
            InitializeComponent();
            IconType IconType = new IconType(type);
            panelType.Controls.Clear();
            panelType.Controls.Add(IconType);
            IconType.Show();

            IconDate IconDate = new IconDate(date);
            panelDate.Controls.Clear();
            panelDate.Controls.Add(IconDate);
            IconDate.Show();

            IconUser IconUser = new IconUser(NbUser);
            panelUser.Controls.Clear();
            panelUser.Controls.Add(IconUser);
            IconUser.Show();
            
            IconTeam IconTeam = new IconTeam(NbTeam);
            panelTeam.Controls.Clear();
            panelTeam.Controls.Add(IconTeam);
            IconTeam.Show();
                        
            IconDescription IconDescription = new IconDescription(description);
            panelDescription.Controls.Clear();
            panelDescription.Controls.Add(IconDescription);
            IconDescription.Show();

            

            for (int i = 0; i <= 25; i++)
            {
                if (i <= 5)
                {
                    UserControl OmbreUtilisateur = new UserControl();
                    OmbreUtilisateur.Name = "OmbreUtilisateur" + i.ToString();
                    OmbreUtilisateur.Size = new Size(950 + 2 * i, 300 + 2 * i);
                    OmbreUtilisateur.Location = new Point(25 - i, 25 - i);
                    OmbreUtilisateur.BackColor = Color.FromArgb(42 + (3 * i), 0, 0, 0);
                    Controls.Add(OmbreUtilisateur);
                    OmbreUtilisateur.Show();
                }
                else
                {
                    UserControl OmbreUtilisateur = new UserControl();
                    OmbreUtilisateur.Name = "OmbreUtilisateur" + i.ToString();
                    OmbreUtilisateur.Size = new Size(950 + 2 * i, 300 + 2 * i);
                    OmbreUtilisateur.Location = new Point(25 - i, 25 - i);
                    OmbreUtilisateur.BackColor = Color.FromArgb(75 - (3 * i), 0, 0, 0);
                    Controls.Add(OmbreUtilisateur);
                    OmbreUtilisateur.Show();
                }
            }



        }
    }
}
