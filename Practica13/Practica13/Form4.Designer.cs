namespace Practica13
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            txtmasa = new TextBox();
            cboUnidadMasa = new ComboBox();
            ButtonConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "Libras a Kilogramos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 51);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 2;
            label2.Text = "ingrese el valor en masa";
            // 
            // txtmasa
            // 
            txtmasa.Location = new Point(269, 86);
            txtmasa.Name = "txtmasa";
            txtmasa.Size = new Size(100, 23);
            txtmasa.TabIndex = 3;
            // 
            // cboUnidadMasa
            // 
            cboUnidadMasa.FormattingEnabled = true;
            cboUnidadMasa.Location = new Point(257, 143);
            cboUnidadMasa.Name = "cboUnidadMasa";
            cboUnidadMasa.Size = new Size(121, 23);
            cboUnidadMasa.TabIndex = 4;
            // 
            // ButtonConvertir
            // 
            ButtonConvertir.Location = new Point(279, 183);
            ButtonConvertir.Name = "ButtonConvertir";
            ButtonConvertir.Size = new Size(75, 23);
            ButtonConvertir.TabIndex = 5;
            ButtonConvertir.Text = "button1";
            ButtonConvertir.UseVisualStyleBackColor = true;
            ButtonConvertir.Click += ButtonConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(279, 220);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 360);
            Controls.Add(lblResultado);
            Controls.Add(ButtonConvertir);
            Controls.Add(cboUnidadMasa);
            Controls.Add(txtmasa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtmasa;
        private ComboBox cboUnidadMasa;
        private Button ButtonConvertir;
        private Label lblResultado;
    }
}