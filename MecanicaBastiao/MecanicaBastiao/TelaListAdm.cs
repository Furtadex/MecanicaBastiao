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
using MecanicaBastiao.Banco.Repositories;

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



        private async void TelaListAdm_Load(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panelCatAdm.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panelCatAdm.Width - 20, panelCatAdm.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panelCatAdm.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();



            panelCatAdm.Region = new Region(path);

            await AtualizarTabela();
        }

        public async Task AtualizarTabela()
        {
            if (entidadeAtual == "Itens")
            {
                var itens = await ItensRepositories.ObterTodos();
                dataGridView1.DataSource = new BindingList<Itens>(itens.ToList());
            }
            else if (entidadeAtual == "Usuario")
            {
                var usuarios = await UsuariosRepository.ObterTodos();
                dataGridView1.DataSource = new BindingList<Usuario>(usuarios.ToList());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var cadastrarUser = new TelaCadastrarUser(this);
            cadastrarUser.Show();
        }

        private async void btnUsuarios_Click(object sender, EventArgs e)
        {
            entidadeAtual = "Usuario";
            await AtualizarTabela();
        }

        private async void btnCatalogo_Click(object sender, EventArgs e)
        {
            entidadeAtual = "Itens";
            await AtualizarTabela();
        }
    }
}
