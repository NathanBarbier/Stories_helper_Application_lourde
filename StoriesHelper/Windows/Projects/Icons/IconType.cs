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
    public partial class IconType : UserControl
    {
        public IconType(string type)
        {
            InitializeComponent();
            titreType.Left = (this.ClientSize.Width - titreType.Width) / 2 ;
            labelType.Text = type;
            labelType.Left = (this.ClientSize.Width - labelType.Width) / 2;
        }
    }
}
