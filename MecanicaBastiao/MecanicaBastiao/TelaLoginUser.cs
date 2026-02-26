using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MecanicaBastiao
{
    public partial class TelaLoginUser : Form
    {
        public TelaLoginUser()
        {
            InitializeComponent();

            Load += TelaLoginUser_Load;
        }

        private void TelaLoginUser_Load(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panelLoginU.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panelLoginU.Width - 20, panelLoginU.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panelLoginU.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            panelLoginU.Region = new Region(path);
        }
        //panelLoginU
        private void panelLoginU_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
