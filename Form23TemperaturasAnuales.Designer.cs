namespace Fundamentos
{
    partial class Form23TemperaturasAnuales
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarMeses = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.txtTempMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.Location = new System.Drawing.Point(12, 58);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(141, 225);
            this.lstMeses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meses";
            // 
            // btnGenerarMeses
            // 
            this.btnGenerarMeses.Location = new System.Drawing.Point(185, 58);
            this.btnGenerarMeses.Name = "btnGenerarMeses";
            this.btnGenerarMeses.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarMeses.TabIndex = 2;
            this.btnGenerarMeses.Text = "GenerarMeses";
            this.btnGenerarMeses.UseVisualStyleBackColor = true;
            this.btnGenerarMeses.Click += new System.EventHandler(this.btnGenerarMeses_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(185, 88);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura Máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperatura Mínima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Temperatura Media";
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(185, 146);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(100, 20);
            this.txtTempMax.TabIndex = 7;
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(185, 207);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.Size = new System.Drawing.Size(100, 20);
            this.txtTempMin.TabIndex = 8;
            // 
            // txtTempMedia
            // 
            this.txtTempMedia.Location = new System.Drawing.Point(185, 263);
            this.txtTempMedia.Name = "txtTempMedia";
            this.txtTempMedia.Size = new System.Drawing.Size(100, 20);
            this.txtTempMedia.TabIndex = 9;
            // 
            // Form23TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 351);
            this.Controls.Add(this.txtTempMedia);
            this.Controls.Add(this.txtTempMin);
            this.Controls.Add(this.txtTempMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerarMeses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMeses);
            this.Name = "Form23TemperaturasAnuales";
            this.Text = "Form23TemperaturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarMeses;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempMax;
        private System.Windows.Forms.TextBox txtTempMin;
        private System.Windows.Forms.TextBox txtTempMedia;
    }
}