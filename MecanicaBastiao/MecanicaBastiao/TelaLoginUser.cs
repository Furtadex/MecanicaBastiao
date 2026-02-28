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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonEntrar_Click(object sender, EventArgs e)
        {
            string email = textBoxUser.Text.Trim();
            string senha = textBoxSenha.Text;

            var usuario = await UsuariosRepository.ObterPorEmailSenha(email, senha);

            if (usuario != null)
            {
                this.Hide();
                TelaCatalogo tela = new TelaCatalogo();
                tela.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha incorretos",
                    "Erro ao realizar login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}