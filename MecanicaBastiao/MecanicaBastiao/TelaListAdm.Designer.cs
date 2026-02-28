namespace MecanicaBastiao
{
    partial class TelaListAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListAdm));
            panelCatalogo = new Panel();
            btn_EntrarU = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelCatalogo
            // 
            panelCatalogo.BackColor = SystemColors.ButtonHighlight;
            panelCatalogo.Controls.Add(button4);
            panelCatalogo.Controls.Add(button3);
            panelCatalogo.Controls.Add(button2);
            panelCatalogo.Controls.Add(button1);
            panelCatalogo.Controls.Add(btn_EntrarU);
            panelCatalogo.Controls.Add(dataGridView1);
            panelCatalogo.Controls.Add(textBox1);
            panelCatalogo.Location = new Point(3, 14);
            panelCatalogo.Name = "panelCatalogo";
            panelCatalogo.Size = new Size(588, 646);
            panelCatalogo.TabIndex = 1;
            // 
            // btn_EntrarU
            // 
            btn_EntrarU.BackColor = SystemColors.ButtonFace;
            btn_EntrarU.Font = new Font("Segoe UI Semibold", 14F);
            btn_EntrarU.Image = (Image)resources.GetObject("btn_EntrarU.Image");
            btn_EntrarU.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EntrarU.Location = new Point(21, 15);
            btn_EntrarU.Name = "btn_EntrarU";
            btn_EntrarU.Size = new Size(245, 70);
            btn_EntrarU.TabIndex = 6;
            btn_EntrarU.Text = "           CATÁLOGO";
            btn_EntrarU.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 420);
            dataGridView1.TabIndex = 4;
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
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Semibold", 14F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(322, 15);
            button1.Name = "button1";
            button1.Size = new Size(245, 70);
            button1.TabIndex = 7;
            button1.Text = "           USUÁRIOS";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(107, 33, 168);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(21, 593);
            button2.Name = "button2";
            button2.Size = new Size(118, 37);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(107, 33, 168);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(235, 593);
            button3.Name = "button3";
            button3.Size = new Size(118, 37);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(107, 33, 168);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(449, 593);
            button4.Name = "button4";
            button4.Size = new Size(118, 37);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = true;
            // 
            // TelaListAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 674);
            Controls.Add(panelCatalogo);
            Name = "TelaListAdm";
            Text = "TelaListAdm";
            panelCatalogo.ResumeLayout(false);
            panelCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCatalogo;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btn_EntrarU;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}