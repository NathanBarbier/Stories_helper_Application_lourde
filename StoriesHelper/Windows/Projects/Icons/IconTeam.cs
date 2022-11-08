using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Projects.Icons
{
    public partial class IconTeam : UserControl
    {
        public IconTeam(int NbTeam)
        {
            InitializeComponent();
            titreTeam.Left = (this.ClientSize.Width - titreTeam.Width) / 2 ;
            labelTeam.Text = NbTeam.ToString();
            labelTeam.Left = (this.ClientSize.Width - labelTeam.Width) / 2;
        }
    }
}
