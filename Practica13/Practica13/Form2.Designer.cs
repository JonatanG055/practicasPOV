namespace Practica13
{
    partial class Form2
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
            textBoxTemperaturaCelsius = new TextBox();
            buttonConvertir = new Button();
            labelTemperaturaCelsius = new Label();
            labelTemperaturaFahrenheit = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 23);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "De Celsius a Fahrengeint";
            // 
            // textBoxTemperaturaCelsius
            // 
            textBoxTemperaturaCelsius.Location = new Point(247, 76);
            textBoxTemperaturaCelsius.Name = "textBoxTemperaturaCelsius";
            textBoxTemperaturaCelsius.Size = new Size(100, 23);
            textBoxTemperaturaCelsius.TabIndex = 1;
            // 
            // buttonConvertir
            // 
            buttonConvertir.Location = new Point(262, 131);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(75, 23);
            buttonConvertir.TabIndex = 2;
            buttonConvertir.Text = "Convertir";
            buttonConvertir.UseVisualStyleBackColor = true;
            buttonConvertir.Click += buttonConvertir_Click;
            // 
            // labelTemperaturaCelsius
            // 
            labelTemperaturaCelsius.AutoSize = true;
            labelTemperaturaCelsius.Location = new Point(247, 49);
            labelTemperaturaCelsius.Name = "labelTemperaturaCelsius";
            labelTemperaturaCelsius.Size = new Size(110, 15);
            labelTemperaturaCelsius.TabIndex = 3;
            labelTemperaturaCelsius.Text = "TemperaturaCelsius";
            // 
            // labelTemperaturaFahrenheit
            // 
            labelTemperaturaFahrenheit.AutoSize = true;
            labelTemperaturaFahrenheit.Location = new Point(231, 102);
            labelTemperaturaFahrenheit.Name = "labelTemperaturaFahrenheit";
            labelTemperaturaFahrenheit.Size = new Size(129, 15);
            labelTemperaturaFahrenheit.TabIndex = 4;
            labelTemperaturaFahrenheit.Text = "TemperaturaFahrenheit";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 360);
            Controls.Add(labelTemperaturaFahrenheit);
            Controls.Add(labelTemperaturaCelsius);
            Controls.Add(buttonConvertir);
            Controls.Add(textBoxTemperaturaCelsius);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTemperaturaCelsius;
        private Button buttonConvertir;
        private Label labelTemperaturaCelsius;
        private Label labelTemperaturaFahrenheit;
    }
}