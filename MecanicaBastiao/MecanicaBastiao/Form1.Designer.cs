namespace MecanicaBastiao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            imageList1 = new ImageList(components);
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.ScrollBar;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(545, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 100);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(390, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 390);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(51, 318);
            label4.Name = "label4";
            label4.Size = new Size(317, 21);
            label4.TabIndex = 7;
            label4.Text = "Selecione uma opção para acessar o sistema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 320);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(83, 85);
            button3.Name = "button3";
            button3.Size = new Size(254, 78);
            button3.TabIndex = 5;
            button3.Text = "                         Entrar como                         Usuário";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(83, 190);
            button2.Name = "button2";
            button2.Size = new Size(254, 78);
            button2.TabIndex = 2;
            button2.Text = "         Entrar como            Administrador";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F);
            label2.Location = new Point(93, 25);
            label2.Name = "label2";
            label2.Size = new Size(234, 28);
            label2.TabIndex = 0;
            label2.Text = "Escolha o tipo de acesso";
            // 
            // label1
            // 
            label1.CausesValidation = false;
            label1.Font = new Font("Sans Serif Collection", 25F, FontStyle.Bold);
            label1.Location = new Point(450, 93);
            label1.Name = "label1";
            label1.Size = new Size(300, 342);
            label1.TabIndex = 4;
            label1.Text = "Oficina Bastião";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(424, 597);
            label5.Name = "label5";
            label5.Size = new Size(352, 19);
            label5.TabIndex = 5;
            label5.Text = "© 2026 Guilherme e Isaac. Todos os direitos reservados.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(490, 626);
            label6.Name = "label6";
            label6.Size = new Size(220, 15);
            label6.TabIndex = 6;
            label6.Text = " Sistema Projeto Integrador | Versão 1.0.0";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(69, 290);
            label7.Name = "label7";
            label7.Size = new Size(282, 15);
            label7.TabIndex = 8;
            label7.Text = "_______________________________________________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 761);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private ImageList imageList1;
        private Label label7;
    }
}
