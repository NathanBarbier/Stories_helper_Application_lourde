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
    public partial class IconDate : UserControl
    {
        public IconDate(string date)
        {
            InitializeComponent();
            titreDate.Left = (this.ClientSize.Width - titreDate.Width) / 2 ;
            labelDate.Text = date;                         
            labelDate.Left = (this.ClientSize.Width - labelDate.Width) / 2;
        }
    }
}
