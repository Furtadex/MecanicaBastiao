namespace MecanicaBastiao
{
    partial class TelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            panelLogin = new Panel();
            pictureBox4 = new PictureBox();
            linkLabel1 = new LinkLabel();
            buttonEntrar = new Button();
            textBoxSenha = new TextBox();
            pictureBox3 = new PictureBox();
            textBoxUser = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = SystemColors.ButtonHighlight;
            panelLogin.Controls.Add(pictureBox4);
            panelLogin.Controls.Add(linkLabel1);
            panelLogin.Controls.Add(buttonEntrar);
            panelLogin.Controls.Add(textBoxSenha);
            panelLogin.Controls.Add(pictureBox3);
            panelLogin.Controls.Add(textBoxUser);
            panelLogin.Controls.Add(pictureBox2);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(button1);
            panelLogin.Location = new Point(14, 16);
            panelLogin.Margin = new Padding(3, 4, 3, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(511, 809);
            panelLogin.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 679);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(472, 83);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(107, 33, 168);
            linkLabel1.AutoSize = true;
            linkLabel1.LinkArea = new LinkArea(0, 0);
            linkLabel1.LinkColor = Color.FromArgb(255, 128, 0);
            linkLabel1.LinkVisited = true;
            linkLabel1.Location = new Point(353, 531);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(132, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.Text = "Esqueceu a senha?";
            linkLabel1.VisitedLinkColor = Color.FromArgb(106, 27, 154);
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = Color.FromArgb(107, 33, 168);
            buttonEntrar.FlatStyle = FlatStyle.Flat;
            buttonEntrar.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            buttonEntrar.ForeColor = SystemColors.ButtonHighlight;
            buttonEntrar.Image = (Image)resources.GetObject("buttonEntrar.Image");
            buttonEntrar.Location = new Point(37, 588);
            buttonEntrar.Margin = new Padding(3, 4, 3, 4);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(438, 67);
            buttonEntrar.TabIndex = 10;
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxSenha.Font = new Font("Segoe UI", 24F);
            textBoxSenha.Location = new Point(37, 437);
            textBoxSenha.Margin = new Padding(3, 4, 3, 4);
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(437, 60);
            textBoxSenha.TabIndex = 8;
            textBoxSenha.TextChanged += textBoxSenha_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(211, 400);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(86, 29);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // textBoxUser
            // 
            textBoxUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxUser.Font = new Font("Segoe UI", 24F);
            textBoxUser.ForeColor = Color.Black;
            textBoxUser.Location = new Point(37, 303);
            textBoxUser.Margin = new Padding(3, 4, 3, 4);
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(437, 66);
            textBoxUser.TabIndex = 6;
            textBoxUser.Tag = "";
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(197, 259);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 36);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(97, 207);
            label3.Name = "label3";
            label3.Size = new Size(349, 28);
            label3.TabIndex = 4;
            label3.Text = "Acesse o painel de gestão da Locadora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 145);
            label2.Name = "label2";
            label2.Size = new Size(316, 41);
            label2.TabIndex = 3;
            label2.Text = "Login Administrativo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label1.Location = new Point(353, 49);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 2;
            label1.Text = "Administrador";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(309, 40);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 46);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(30, 40);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 49);
            button1.TabIndex = 0;
            button1.Text = "     Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 843);
            Controls.Add(panelLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaLogin";
            Text = "Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private Button button3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox4;
        private Button buttonEntrar;
        private TextBox textBoxSenha;
        private TextBox textBoxUser;
    }
}