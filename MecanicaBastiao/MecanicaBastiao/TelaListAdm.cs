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

            await AtualizarTabela(null);
        }

        public async Task AtualizarTabela(string filter)
        {
            if (entidadeAtual == "Itens")
            {
                var itens = string.IsNullOrWhiteSpace(filter)
                            ? await ItensRepositories.ObterTodos()
                            : await ItensRepositories.ObterPorNome(filter);
                dataGridView1.DataSource = new BindingList<Itens>(itens.ToList());
            }
            else if (entidadeAtual == "Usuario")
            {
                var usuarios = string.IsNullOrWhiteSpace(filter)
                                ? await UsuariosRepository.ObterTodos()
                                : await UsuariosRepository.ObterPorNome(filter);
                dataGridView1.DataSource = new BindingList<Usuario>(usuarios.ToList());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var cadastrarUser = new TelaCadastrarUser(this, null);
            cadastrarUser.Show();
        }

        private async void btnUsuarios_Click(object sender, EventArgs e)
        {
            entidadeAtual = "Usuario";
            await AtualizarTabela(null);
        }

        private async void btnCatalogo_Click(object sender, EventArgs e)
        {
            entidadeAtual = "Itens";
            await AtualizarTabela(null);
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um registro para editar.");
                return;
            }

            if (entidadeAtual == "Itens")
            {
                var itemSelecionado = (Itens)dataGridView1.CurrentRow.DataBoundItem;

                var telaEdit = new TelaEditar(itemSelecionado);
                if (telaEdit.ShowDialog() == DialogResult.OK)
                {
                    await AtualizarTabela(null);
                }
            }
            else if (entidadeAtual == "Usuario")
            {
                var usuarioSelecionado = (Usuario)dataGridView1.CurrentRow.DataBoundItem;

                var telaEdit = new TelaCadastrarUser(this, usuarioSelecionado);
                if (telaEdit.ShowDialog() == DialogResult.OK)
                {
                    await AtualizarTabela(null);
                }
            }

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacao = MessageBox.Show("Tem certeza que deseja excluir este registro?",
                                             "Confirmar Exclusão",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    if (entidadeAtual == "Itens")
                    {
                        var item = (Itens)dataGridView1.CurrentRow.DataBoundItem;

                        await ItensRepositories.Deletar(item.Id);
                    }
                    else if (entidadeAtual == "Usuario")
                    {
                        var usuario = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
                        await UsuariosRepository.Deletar(usuario.Id);
                    }

                    await AtualizarTabela(null);
                    MessageBox.Show("Registro excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            AtualizarTabela(textBox.Text);
        }
    }
}
