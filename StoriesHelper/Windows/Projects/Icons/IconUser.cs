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
    public partial class IconUser : UserControl
    {
        public IconUser(int NbUser)
        {
            InitializeComponent();
            titreUser.Left = (this.ClientSize.Width - titreUser.Width) / 2 ;
            labelUser.Text = NbUser.ToString();
            labelUser.Left = (this.ClientSize.Width - labelUser.Width) / 2;
        }
    }
}
