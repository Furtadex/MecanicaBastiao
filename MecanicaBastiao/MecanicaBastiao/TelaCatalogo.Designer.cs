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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            panelCatalogo.Controls.Add(button3);
            panelCatalogo.Controls.Add(button2);
            panelCatalogo.Controls.Add(button1);
            panelCatalogo.Controls.Add(label4);
            panelCatalogo.Controls.Add(dataGridView2);
            panelCatalogo.Controls.Add(panelUser);
            panelCatalogo.Controls.Add(pictureBox1);
            panelCatalogo.Controls.Add(label1);
            panelCatalogo.Controls.Add(textBox1);
            panelCatalogo.Location = new Point(18, 11);
            panelCatalogo.Margin = new Padding(3, 4, 3, 4);
            panelCatalogo.Name = "panelCatalogo";
            panelCatalogo.Size = new Size(672, 861);
            panelCatalogo.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(513, 791);
            button3.Name = "button3";
            button3.Size = new Size(135, 49);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(269, 791);
            button2.Name = "button2";
            button2.Size = new Size(135, 49);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(24, 791);
            button1.Name = "button1";
            button1.Size = new Size(135, 49);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(91, 57);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 5;
            label4.Text = "Editar com código count";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(24, 217);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(624, 560);
            dataGridView2.TabIndex = 4;
            // 
            // panelUser
            // 
            panelUser.BackColor = SystemColors.Control;
            panelUser.Controls.Add(label3);
            panelUser.Controls.Add(label2);
            panelUser.Location = new Point(482, 19);
            panelUser.Margin = new Padding(3, 4, 3, 4);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(166, 76);
            panelUser.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 39);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 1;
            label3.Text = "ALTERAR";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 0;
            label2.Text = "Usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 19);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 76);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 19);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 1;
            label1.Text = "Catálogo de Filmes";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(24, 135);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(624, 41);
            textBox1.TabIndex = 0;
            // 
            // TelaCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 899);
            Controls.Add(panelCatalogo);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
        private Button button2;
        private Button button3;
    }
}