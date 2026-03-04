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
    public partial class TelaCatalogo : Form
    {
        private Usuario usuario;

        public TelaCatalogo(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            label3.Text = usuario.Nome;

            Load += TelaCatalogo_Load;

            Load += panelUser_Load;
        }

        private async void TelaCatalogo_Load(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panelCatalogo.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panelCatalogo.Width - 20, panelCatalogo.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panelCatalogo.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            panelCatalogo.Region = new Region(path);

            await AtualizarTabela();
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

        public async Task AtualizarTabela()
        {
            var itens = await ItensRepositories.ObterTodos();

            dataGridView2.DataSource = new BindingList<Itens>(itens.ToList());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idItem = (int)dataGridView2.SelectedRows[0].Cells[0].Value;

            var aluguel = new Aluguel
            {
                IdUsuario = usuario.Id,
                IdItem = idItem,
                DataAluguel = DateTime.Now,
                Ativo = 1,
                DataDevolucao = CalcularDataDevolucao(
                

            };

        }

        public DateTime CalcularDataDevolucao(string categoria, DateTime dataAluguel)
        {
            int diasPrazo = 0;

            switch (categoria.ToLower())
            {
                case "ouro":
                    diasPrazo = 7;
                    break;

                case "prata":
                    diasPrazo = 14;
                    break;

                case "bronze":
                    diasPrazo = 21;
                    break;

                default:
                    throw new Exception("Categoria inválida.");
            }

            return dataAluguel.AddDays(diasPrazo);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
