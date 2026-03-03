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
            panelCatAdm = new Panel();
            btnNovo = new Button();
            button3 = new Button();
            button2 = new Button();
            btnUsuarios = new Button();
            btnCatalogo = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            panelCatAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelCatAdm
            // 
            panelCatAdm.BackColor = SystemColors.ButtonHighlight;
            panelCatAdm.Controls.Add(btnNovo);
            panelCatAdm.Controls.Add(button3);
            panelCatAdm.Controls.Add(button2);
            panelCatAdm.Controls.Add(btnUsuarios);
            panelCatAdm.Controls.Add(btnCatalogo);
            panelCatAdm.Controls.Add(dataGridView1);
            panelCatAdm.Controls.Add(textBox1);
            panelCatAdm.Location = new Point(10, 10);
            panelCatAdm.Name = "panelCatAdm";
            panelCatAdm.Size = new Size(588, 646);
            panelCatAdm.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = Color.FromArgb(107, 33, 168);
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.Location = new Point(449, 593);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(118, 37);
            btnNovo.TabIndex = 17;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
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
            // btnUsuarios
            // 
            btnUsuarios.BackColor = SystemColors.ButtonFace;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 14F);
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(322, 15);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(245, 70);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCatalogo
            // 
            btnCatalogo.BackColor = SystemColors.ButtonFace;
            btnCatalogo.Font = new Font("Segoe UI Semibold", 14F);
            btnCatalogo.Image = (Image)resources.GetObject("btnCatalogo.Image");
            btnCatalogo.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatalogo.Location = new Point(21, 15);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(245, 70);
            btnCatalogo.TabIndex = 6;
            btnCatalogo.UseVisualStyleBackColor = false;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(546, 420);
            dataGridView1.TabIndex = 4;
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
            // TelaListAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 674);
            Controls.Add(panelCatAdm);
            Name = "TelaListAdm";
            Text = "TelaListAdm";
            panelCatAdm.ResumeLayout(false);
            panelCatAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCatAdm;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btnCatalogo;
        private Button btnUsuarios;
        private Button button3;
        private Button button2;
        private Button btnNovo;
    }
}