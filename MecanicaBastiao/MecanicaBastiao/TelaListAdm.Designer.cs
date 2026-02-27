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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btn_EntrarU = new Button();
            panelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelCatalogo
            // 
            panelCatalogo.BackColor = SystemColors.ButtonHighlight;
            panelCatalogo.Controls.Add(btn_EntrarU);
            panelCatalogo.Controls.Add(dataGridView1);
            panelCatalogo.Controls.Add(textBox1);
            panelCatalogo.Location = new Point(3, 14);
            panelCatalogo.Name = "panelCatalogo";
            panelCatalogo.Size = new Size(588, 646);
            panelCatalogo.TabIndex = 1;
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
            // btn_EntrarU
            // 
            btn_EntrarU.BackColor = SystemColors.GradientInactiveCaption;
            btn_EntrarU.Font = new Font("Segoe UI Semibold", 12F);
            btn_EntrarU.Image = (Image)resources.GetObject("btn_EntrarU.Image");
            btn_EntrarU.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EntrarU.Location = new Point(36, 25);
            btn_EntrarU.Name = "btn_EntrarU";
            btn_EntrarU.Size = new Size(169, 70);
            btn_EntrarU.TabIndex = 6;
            btn_EntrarU.UseVisualStyleBackColor = false;
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
    }
}