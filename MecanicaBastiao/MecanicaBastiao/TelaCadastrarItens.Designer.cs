using MecanicaBastiao.Banco.Repositories;

namespace MecanicaBastiao
{
    partial class TelaCadastrarItens
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

        private Itens itemEdicao;

        public TelaCadastrarItens(Itens item)
        {
            InitializeComponent();
            itemEdicao = item;

            txtNome.Text = item.Nome;
            txtPreco.Text = item.Preco.ToString();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarItens));
            panelCadastro = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label7 = new Label();
            buttonEntrar = new Button();
            panel1 = new Panel();
            label6 = new Label();
            radioButton1 = new RadioButton();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            txtPreco = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCadastro
            // 
            panelCadastro.BackColor = SystemColors.ButtonHighlight;
            panelCadastro.Controls.Add(pictureBox1);
            panelCadastro.Controls.Add(button1);
            panelCadastro.Controls.Add(label7);
            panelCadastro.Controls.Add(buttonEntrar);
            panelCadastro.Controls.Add(panel1);
            panelCadastro.Controls.Add(label5);
            panelCadastro.Controls.Add(label3);
            panelCadastro.Controls.Add(label2);
            panelCadastro.Controls.Add(textBox5);
            panelCadastro.Controls.Add(label4);
            panelCadastro.Controls.Add(txtPreco);
            panelCadastro.Controls.Add(textBox3);
            panelCadastro.Controls.Add(textBox2);
            panelCadastro.Controls.Add(label1);
            panelCadastro.Controls.Add(txtNome);
            panelCadastro.Location = new Point(14, 16);
            panelCadastro.Margin = new Padding(3, 4, 3, 4);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(672, 861);
            panelCadastro.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(107, 33, 168);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(501, 43);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(135, 49);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(89, 29);
            label7.Name = "label7";
            label7.Size = new Size(197, 37);
            label7.TabIndex = 13;
            label7.Text = "Cadastrar Item";
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = Color.FromArgb(107, 33, 168);
            buttonEntrar.FlatStyle = FlatStyle.Flat;
            buttonEntrar.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            buttonEntrar.ForeColor = SystemColors.ButtonHighlight;
            buttonEntrar.Image = (Image)resources.GetObject("buttonEntrar.Image");
            buttonEntrar.Location = new Point(40, 749);
            buttonEntrar.Margin = new Padding(3, 4, 3, 4);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(597, 67);
            buttonEntrar.TabIndex = 11;
            buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(39, 624);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 95);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 12);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 1;
            label6.Text = "Disponível";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackgroundImageLayout = ImageLayout.None;
            radioButton1.CheckAlign = ContentAlignment.MiddleCenter;
            radioButton1.Location = new Point(558, 39);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 529);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 9;
            label5.Text = "URL da Imagem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 413);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 6;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 224);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 13F);
            textBox5.Location = new Point(39, 556);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(596, 41);
            textBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(345, 413);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 7;
            label4.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.BorderStyle = BorderStyle.FixedSingle;
            txtPreco.Font = new Font("Segoe UI", 13F);
            txtPreco.Location = new Point(345, 440);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(291, 41);
            txtPreco.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(40, 440);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(291, 41);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(40, 251);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(596, 118);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 119);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 13F);
            txtNome.Location = new Point(40, 145);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.Size = new Size(596, 41);
            txtNome.TabIndex = 0;
            // 
            // TelaCadastrarItens
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 891);
            Controls.Add(panelCadastro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaCadastrarItens";
            Text = "Form1";
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCadastro;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox txtPreco;
        private TextBox textBox5;
        private Label label5;
        private Panel panel1;
        private Button buttonEntrar;
        private RadioButton radioButton1;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label7;
    }
}