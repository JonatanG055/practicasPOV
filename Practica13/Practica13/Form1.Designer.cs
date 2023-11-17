namespace Practica13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel3 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            conversor1 = new Button();
            pictureBox1 = new PictureBox();
            contexpanel = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(2, 35, 64);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(112, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(621, 96);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(197, 39);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 1;
            label1.Text = "Calculadora de Conversion";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(571, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 93, 39);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(conversor1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(112, 495);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 232);
            button3.Name = "button3";
            button3.Size = new Size(112, 41);
            button3.TabIndex = 3;
            button3.Text = "Libras a Kilogramos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 172);
            button2.Name = "button2";
            button2.Size = new Size(112, 41);
            button2.TabIndex = 2;
            button2.Text = "Metros a Centimetros";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // conversor1
            // 
            conversor1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            conversor1.FlatAppearance.BorderSize = 0;
            conversor1.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            conversor1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            conversor1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            conversor1.FlatStyle = FlatStyle.Flat;
            conversor1.Location = new Point(0, 125);
            conversor1.Name = "conversor1";
            conversor1.Size = new Size(112, 41);
            conversor1.TabIndex = 1;
            conversor1.Text = "De Celsius a Fahrengeint";
            conversor1.UseVisualStyleBackColor = true;
            conversor1.Click += conversor1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contexpanel
            // 
            contexpanel.Dock = DockStyle.Fill;
            contexpanel.Location = new Point(112, 96);
            contexpanel.Name = "contexpanel";
            contexpanel.Size = new Size(621, 399);
            contexpanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 495);
            Controls.Add(contexpanel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel contexpanel;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button conversor1;
    }
}