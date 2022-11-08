using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StoriesHelper.Services
{
    public partial class LigneVerticale : Panel
    {
        public LigneVerticale()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(180, 0, 0, 0));
            e.Graphics.DrawLine(pen, 0, this.ClientSize.Height, 0, 0);
        }
    }
}
