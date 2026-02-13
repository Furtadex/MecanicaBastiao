using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MecanicaBastiao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panel1.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panel1.Width - 20, panel1.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panel1.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new Region(path);
        }
    }
}
