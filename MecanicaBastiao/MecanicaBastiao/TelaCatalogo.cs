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
    public partial class TelaCatalogo : Form
    {
        public TelaCatalogo()
        {
            InitializeComponent();

            Load += TelaCatalogo_Load;

            Load += panelUser_Load;
        }

        private void TelaCatalogo_Load(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panelCatalogo.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panelCatalogo.Width - 20, panelCatalogo.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panelCatalogo.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            panelCatalogo.Region = new Region(path);

        }

        private void panelUser_Load(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panelUser.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panelUser.Width - 20, panelUser.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panelUser.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            panelUser.Region = new Region(path);
        }
    }
}
