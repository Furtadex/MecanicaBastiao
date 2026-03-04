namespace MecanicaBastiao
{
    partial class TelaEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditar));
            panelCadastro = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label7 = new Label();
            buttonEntrar = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtPreco = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
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
            panelCadastro.Controls.Add(label3);
            panelCadastro.Controls.Add(label2);
            panelCadastro.Controls.Add(label4);
            panelCadastro.Controls.Add(txtPreco);
            panelCadastro.Controls.Add(textBox3);
            panelCadastro.Controls.Add(textBox2);
            panelCadastro.Controls.Add(label1);
            panelCadastro.Controls.Add(txtNome);
            panelCadastro.Location = new Point(25, 12);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(588, 576);
            panelCadastro.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 47);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(107, 33, 168);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(438, 32);
            button1.Name = "button1";
            button1.Size = new Size(118, 37);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(78, 22);
            label7.Name = "label7";
            label7.Size = new Size(119, 30);
            label7.TabIndex = 13;
            label7.Text = "Editar Item";
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = Color.FromArgb(107, 33, 168);
            buttonEntrar.FlatStyle = FlatStyle.Flat;
            buttonEntrar.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            buttonEntrar.ForeColor = SystemColors.ButtonHighlight;
            buttonEntrar.Image = (Image)resources.GetObject("buttonEntrar.Image");
            buttonEntrar.Location = new Point(34, 487);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(522, 50);
            buttonEntrar.TabIndex = 11;
            buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(34, 388);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 71);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 9);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 1;
            label6.Text = "Disponível";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 310);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 6;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 168);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 310);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 7;
            label4.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.BorderStyle = BorderStyle.FixedSingle;
            txtPreco.Font = new Font("Segoe UI", 13F);
            txtPreco.Location = new Point(302, 330);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(255, 31);
            txtPreco.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(35, 330);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(35, 188);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(522, 89);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 89);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 13F);
            txtNome.Location = new Point(35, 109);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.Size = new Size(522, 31);
            txtNome.TabIndex = 0;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(443, 14);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sim";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(443, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Não";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // TelaEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 627);
            Controls.Add(panelCadastro);
            Name = "TelaEditar";
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
        private PictureBox pictureBox1;
        private Button button1;
        private Label label7;
        private Button buttonEntrar;
        private Panel panel1;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtPreco;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label1;
        private TextBox txtNome;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}