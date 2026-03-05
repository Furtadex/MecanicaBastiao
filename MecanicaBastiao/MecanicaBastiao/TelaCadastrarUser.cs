using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MecanicaBastiao.Banco.Repositories;

namespace MecanicaBastiao
{
    public partial class TelaCadastrarUser : Form
    {
        public TelaCadastrarUser(TelaListAdm telaListAdm, Usuario usuario)
        {
            InitializeComponent();
            if (telaListAdm != null) FillContent(usuario);
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
              
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Telefone = txtTelefone.Text,
                DataNascimento = dtDataNascimento.Value, 
                Cpf = txtCPF.Text
            };

            try
            {                
                await UsuariosRepository.Adicionar(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
