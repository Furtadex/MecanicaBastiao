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
            panelUser = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panelCatalogo.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelCatalogo
            // 
            panelCatalogo.BackColor = SystemColors.ButtonHighlight;
            panelCatalogo.Controls.Add(label4);
            panelCatalogo.Controls.Add(dataGridView1);
            panelCatalogo.Controls.Add(panelUser);
            panelCatalogo.Controls.Add(pictureBox1);
            panelCatalogo.Controls.Add(label1);
            panelCatalogo.Controls.Add(textBox1);
            panelCatalogo.Location = new Point(16, 8);
            panelCatalogo.Name = "panelCatalogo";
            panelCatalogo.Size = new Size(588, 646);
            panelCatalogo.TabIndex = 0;
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
            pictureBox1.Size = new Size(47, 46);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 14);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 1;
            label1.Text = "Catálogo de Filmes";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(21, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(546, 31);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 420);
            dataGridView1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(78, 42);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 5;
            label4.Text = "Editar com código count";
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
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label4;
    }
}