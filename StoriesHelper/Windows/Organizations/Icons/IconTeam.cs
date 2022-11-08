using StoriesHelper.Properties;
using StoriesHelper.Repository;
using StoriesHelper.Services;
using StoriesHelper.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations.Icons
{
    public partial class IconTeam : UserControl
    {
        public IconTeam()
        {
            InitializeComponent();

            TeamRepository TeamRepository = new TeamRepository();

            int NbTeamOpen = TeamRepository.GetTeamsByOrganization(Session.UserId, pagination: false).Count();
            int NbTeamArchived = TeamRepository.GetTeamsByOrganization(Session.UserId, false, true, pagination: false).Count();

            Label TitreOpen = new Label();
            TitreOpen.Name = "TitreNbEquipeOpen";
            TitreOpen.Text = "Équipes Ouvertes";
            TitreOpen.Location = new Point(40, 115);
            TitreOpen.BackColor = Color.White;
            TitreOpen.UseMnemonic = true;
            TitreOpen.AutoSize = true;
            TitreOpen.Font = new Font("Cambria", 10, FontStyle.Bold);
            Controls.Add(TitreOpen);

            Label NombreOpen = new Label();
            NombreOpen.Name = "NombreOpen";
            NombreOpen.Text = NbTeamOpen.ToString();
            NombreOpen.Location = new Point(65, 130);
            NombreOpen.BackColor = Color.White;
            NombreOpen.UseMnemonic = true;
            NombreOpen.AutoSize = true;
            NombreOpen.Font = new Font("Cambria", 14, FontStyle.Bold);
            Controls.Add(NombreOpen);

            Label TitreArchived = new Label();
            TitreArchived.Name = "TitreNbEquipeArchived";
            TitreArchived.Text = "Équipes Archivées";
            TitreArchived.Location = new Point(25, 155);
            TitreArchived.ForeColor = Color.Red;
            TitreArchived.BackColor = Color.White;
            TitreArchived.UseMnemonic = true;
            TitreArchived.AutoSize = true;
            TitreArchived.Font = new Font("Cambria", 10, FontStyle.Bold);
            Controls.Add(TitreArchived);

            Label NombreArchived = new Label();
            NombreArchived.Name = "NombreArchived";
            NombreArchived.Text = NbTeamArchived.ToString();
            NombreArchived.Location = new Point(65, 170);
            NombreArchived.ForeColor = Color.Red;
            NombreArchived.BackColor = Color.White;
            NombreArchived.UseMnemonic = true;
            NombreArchived.AutoSize = true;
            NombreArchived.Font = new Font("Cambria", 14, FontStyle.Bold);
            Controls.Add(NombreArchived);

            IconeUser IconeUser = new IconeUser();
            IconeUser.Size = new Size(150, 175);
            IconeUser.Location = new Point(25, 25);
            Controls.Add(IconeUser);

            for (int i = 0; i <= 25; i++)
            {
                if (i <= 5)
                {
                    UserControl OmbreUtilisateur = new UserControl();
                    OmbreUtilisateur.Name = "OmbreUtilisateur" + i.ToString();
                    OmbreUtilisateur.Size = new Size(150 + 2 * i, 175 + 2 * i);
                    OmbreUtilisateur.Location = new Point(25 - i, 25 - i);
                    OmbreUtilisateur.BackColor = Color.FromArgb(42 + (3 * i), 0, 0, 0);
                    Controls.Add(OmbreUtilisateur);
                    OmbreUtilisateur.Show();
                }
                else
                {
                    UserControl OmbreUtilisateur = new UserControl();
                    OmbreUtilisateur.Name = "OmbreUtilisateur" + i.ToString();
                    OmbreUtilisateur.Size = new Size(150 + 2 * i, 175 + 2 * i);
                    OmbreUtilisateur.Location = new Point(25 - i, 25 - i);
                    OmbreUtilisateur.BackColor = Color.FromArgb(75 - (3 * i), 0, 0, 0);
                    Controls.Add(OmbreUtilisateur);
                    OmbreUtilisateur.Show();
                }
            }

            NombreOpen.Left = (200 - NombreOpen.Width) / 2;
            NombreArchived.Left = (200 - NombreArchived.Width) / 2;
            TitreOpen.Left = (200 - TitreOpen.Width) / 2;
            TitreArchived.Left = (200 - TitreArchived.Width) / 2;
        }
    }
}
