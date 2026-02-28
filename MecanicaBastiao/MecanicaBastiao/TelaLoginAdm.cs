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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

            Load += panelLoginLoad;

            Load += buttonEntrarLoad;
        }

        private void buttonEntrarLoad(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(buttonEntrar.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(buttonEntrar.Width - 20, buttonEntrar.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, buttonEntrar.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            buttonEntrar.Region = new Region(path);
        }

        private void panelLoginLoad(object? sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(panelLogin.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(panelLogin.Width - 20, panelLogin.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, panelLogin.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            panelLogin.Region = new Region(path);
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxSenha.Text == "admin")
            {
                var telaCatalogo = new TelaCatalogo();
                this.Hide();
                telaCatalogo.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos",
                    "Erro ao realizar login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
