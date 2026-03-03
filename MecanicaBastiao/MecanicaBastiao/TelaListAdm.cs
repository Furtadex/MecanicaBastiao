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
    public partial class TelaListAdm : Form
    {
        private string entidadeAtual = "Itens";

        public TelaListAdm()
        {
            InitializeComponent();

            Load += TelaListAdm_Load;
        }

        private void TelaListAdm_Load(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panelCatAdm.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panelCatAdm.Width - 20, panelCatAdm.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panelCatAdm.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            panelCatAdm.Region = new Region(path);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var cadastrarUser = new TelaCadastrarUser(this);
            cadastrarUser.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
