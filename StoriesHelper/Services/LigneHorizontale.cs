using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StoriesHelper.Services
{
    public partial class LigneHorizontale : Panel
    {
        public float width;
        public LigneHorizontale()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(180, 0, 0, 0));
            e.Graphics.DrawLine(pen, this.ClientSize.Width, 0, 0, 0);
        }
    }
}
