namespace Fundamentos
{
    partial class Form19TemperaturasClases
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
            this.txtTemperaturaMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemperaturaMinima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperaturaMaxima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTemperaturaMedia
            // 
            this.txtTemperaturaMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTemperaturaMedia.Location = new System.Drawing.Point(387, 429);
            this.txtTemperaturaMedia.Name = "txtTemperaturaMedia";
            this.txtTemperaturaMedia.Size = new System.Drawing.Size(228, 35);
            this.txtTemperaturaMedia.TabIndex = 19;
            this.txtTemperaturaMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temperatura media mensual";
            // 
            // txtTemperaturaMinima
            // 
            this.txtTemperaturaMinima.ForeColor = System.Drawing.Color.Blue;
            this.txtTemperaturaMinima.Location = new System.Drawing.Point(382, 335);
            this.txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            this.txtTemperaturaMinima.Size = new System.Drawing.Size(233, 35);
            this.txtTemperaturaMinima.TabIndex = 17;
            this.txtTemperaturaMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperatura mínima";
            // 
            // txtTemperaturaMaxima
            // 
            this.txtTemperaturaMaxima.ForeColor = System.Drawing.Color.Red;
            this.txtTemperaturaMaxima.Location = new System.Drawing.Point(379, 245);
            this.txtTemperaturaMaxima.Name = "txtTemperaturaMaxima";
            this.txtTemperaturaMaxima.Size = new System.Drawing.Size(236, 35);
            this.txtTemperaturaMaxima.TabIndex = 15;
            this.txtTemperaturaMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temperatura máxima";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(373, 50);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(242, 53);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar temperaturas";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 30;
            this.lstMeses.Location = new System.Drawing.Point(45, 50);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(259, 424);
            this.lstMeses.TabIndex = 11;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Meses";
            // 
            // Form19TemperaturasClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 505);
            this.Controls.Add(this.txtTemperaturaMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemperaturaMinima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemperaturaMaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form19TemperaturasClases";
            this.Text = "Form19TemperaturasClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTemperaturaMedia;
        private Label label4;
        private TextBox txtTemperaturaMinima;
        private Label label3;
        private TextBox txtTemperaturaMaxima;
        private Label label2;
        private Button btnGenerar;
        private ListBox lstMeses;
        private Label label1;
    }
}