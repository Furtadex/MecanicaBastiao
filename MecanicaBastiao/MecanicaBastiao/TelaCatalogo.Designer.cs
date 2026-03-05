namespace MecanicaBastiao
{
    partial class TelaCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCatalogo));
            panelCatalogo = new Panel();
            btnDevolver = new Button();
            btnAlugar = new Button();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            panelUser = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCatalogo
            // 
            panelCatalogo.BackColor = SystemColors.ButtonHighlight;
            panelCatalogo.Controls.Add(btnDevolver);
            panelCatalogo.Controls.Add(btnAlugar);
            panelCatalogo.Controls.Add(label4);
            panelCatalogo.Controls.Add(dataGridView2);
            panelCatalogo.Controls.Add(panelUser);
            panelCatalogo.Controls.Add(pictureBox1);
            panelCatalogo.Controls.Add(label1);
            panelCatalogo.Controls.Add(textBox1);
            panelCatalogo.Location = new Point(16, 8);
            panelCatalogo.Name = "panelCatalogo";
            panelCatalogo.Size = new Size(588, 646);
            panelCatalogo.TabIndex = 0;
            // 
            // btnDevolver
            // 
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Image = (Image)resources.GetObject("btnDevolver.Image");
            btnDevolver.Location = new Point(235, 593);
            btnDevolver.Margin = new Padding(3, 2, 3, 2);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(118, 37);
            btnDevolver.TabIndex = 7;
            btnDevolver.UseVisualStyleBackColor = true;
            // 
            // btnAlugar
            // 
            btnAlugar.FlatStyle = FlatStyle.Flat;
            btnAlugar.Image = (Image)resources.GetObject("btnAlugar.Image");
            btnAlugar.Location = new Point(21, 593);
            btnAlugar.Margin = new Padding(3, 2, 3, 2);
            btnAlugar.Name = "btnAlugar";
            btnAlugar.Size = new Size(118, 37);
            btnAlugar.TabIndex = 6;
            btnAlugar.UseVisualStyleBackColor = true;
            btnAlugar.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(80, 43);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 5;
            label4.Text = "Editar com código count";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(21, 163);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(546, 420);
            dataGridView2.TabIndex = 4;
            // 
            // panelUser
            // 
            panelUser.BackColor = SystemColors.Control;
            panelUser.Controls.Add(label3);
            panelUser.Controls.Add(label2);
            panelUser.Location = new Point(422, 14);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(145, 57);
            panelUser.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 29);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 1;
            label3.Text = "ALTERAR";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 0;
            label2.Text = "Usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 57);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 14);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 1;
            label1.Text = "Catálogo de Filmes";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(21, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(546, 31);
            textBox1.TabIndex = 0;
            // 
            // TelaCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 674);
            Controls.Add(panelCatalogo);
            Name = "TelaCatalogo";
            Text = "Form1";
            panelCatalogo.ResumeLayout(false);
            panelCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCatalogo;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelUser;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label4;
        private Button btnAlugar;
        private Button btnDevolver;
        private Button button3;
    }
}