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
    public partial class IconDescription : UserControl
    {
        public IconDescription(string description)
        {
            InitializeComponent();
            titreDescription.Left = (this.ClientSize.Width - titreDescription.Width) / 2 ;
            labelDescription.Text = "       \"" + description + " \"";                         
        }
    }
}
