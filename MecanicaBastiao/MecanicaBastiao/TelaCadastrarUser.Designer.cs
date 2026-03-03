namespace MecanicaBastiao
{
    partial class TelaCadastrarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarUser));
            panelCadastro = new Panel();
            label8 = new Label();
            txtCPF = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            txtTelefone = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            button1 = new Button();
            btnCadastrar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label6 = new Label();
            dtDataNascimento = new DateTimePicker();
            panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCadastro
            // 
            panelCadastro.BackColor = SystemColors.ButtonHighlight;
            panelCadastro.Controls.Add(dtDataNascimento);
            panelCadastro.Controls.Add(label8);
            panelCadastro.Controls.Add(txtCPF);
            panelCadastro.Controls.Add(label5);
            panelCadastro.Controls.Add(label4);
            panelCadastro.Controls.Add(label3);
            panelCadastro.Controls.Add(label7);
            panelCadastro.Controls.Add(pictureBox1);
            panelCadastro.Controls.Add(txtTelefone);
            panelCadastro.Controls.Add(txtSenha);
            panelCadastro.Controls.Add(txtEmail);
            panelCadastro.Controls.Add(button1);
            panelCadastro.Controls.Add(btnCadastrar);
            panelCadastro.Controls.Add(label1);
            panelCadastro.Controls.Add(txtNome);
            panelCadastro.Controls.Add(label2);
            panelCadastro.Controls.Add(label6);
            panelCadastro.Location = new Point(13, 41);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(588, 646);
            panelCadastro.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 196);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 25;
            label8.Text = "Senha";
            // 
            // txtCPF
            // 
            txtCPF.BorderStyle = BorderStyle.FixedSingle;
            txtCPF.Font = new Font("Segoe UI", 13F);
            txtCPF.Location = new Point(35, 397);
            txtCPF.Multiline = true;
            txtCPF.Name = "txtCPF";
            txtCPF.RightToLeft = RightToLeft.No;
            txtCPF.Size = new Size(522, 31);
            txtCPF.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 316);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 22;
            label5.Text = "Data de Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 256);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 21;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 379);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 20;
            label3.Text = "CPF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(80, 14);
            label7.Name = "label7";
            label7.Size = new Size(184, 30);
            label7.TabIndex = 13;
            label7.Text = "Cadastrar Usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 39);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;
            txtTelefone.Font = new Font("Segoe UI", 13F);
            txtTelefone.Location = new Point(35, 274);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.Size = new Size(522, 31);
            txtTelefone.TabIndex = 17;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 13F);
            txtSenha.Location = new Point(35, 214);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.Size = new Size(522, 31);
            txtSenha.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(34, 156);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.Size = new Size(522, 28);
            txtEmail.TabIndex = 15;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(107, 33, 168);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(438, 38);
            button1.Name = "button1";
            button1.Size = new Size(118, 37);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(107, 33, 168);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new Point(33, 451);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.RightToLeft = RightToLeft.Yes;
            btnCadastrar.Size = new Size(522, 50);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 13F);
            txtNome.Location = new Point(34, 93);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.Size = new Size(522, 31);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 138);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 19;
            label2.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(90, 38);
            label6.Name = "label6";
            label6.Size = new Size(223, 15);
            label6.TabIndex = 24;
            label6.Text = "Convide um novo Usuário para o sistema";
            // 
            // dtDataNascimento
            // 
            dtDataNascimento.Location = new Point(35, 343);
            dtDataNascimento.Name = "dtDataNascimento";
            dtDataNascimento.Size = new Size(522, 23);
            dtDataNascimento.TabIndex = 26;
            // 
            // TelaCadastrarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 668);
            Controls.Add(panelCadastro);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaCadastrarUser";
            Text = "TelaCadastrarUser";
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCadastro;
        private Button button1;
        private Label label7;
        private PictureBox pictureBox1;
        private Button btnCadastrar;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCPF;
        private Label label6;
        private Label label8;
        private DateTimePicker dtDataNascimento;
    }
}