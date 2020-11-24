namespace Fundamentos
{
    partial class Forms08Char
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtletras = new System.Windows.Forms.TextBox();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsimbolos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpuntuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(52, 72);
            this.txtletras.Multiline = true;
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(266, 96);
            this.txtletras.TabIndex = 1;
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(52, 243);
            this.txtnumeros.Multiline = true;
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(266, 96);
            this.txtnumeros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numeros";
            // 
            // txtsimbolos
            // 
            this.txtsimbolos.Location = new System.Drawing.Point(346, 72);
            this.txtsimbolos.Multiline = true;
            this.txtsimbolos.Name = "txtsimbolos";
            this.txtsimbolos.Size = new System.Drawing.Size(266, 96);
            this.txtsimbolos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Simbolos";
            // 
            // txtpuntuacion
            // 
            this.txtpuntuacion.Location = new System.Drawing.Point(346, 243);
            this.txtpuntuacion.Multiline = true;
            this.txtpuntuacion.Name = "txtpuntuacion";
            this.txtpuntuacion.Size = new System.Drawing.Size(266, 96);
            this.txtpuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuacion";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(292, 360);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrer.TabIndex = 8;
            this.btnRecorrer.Text = "Recorre ASCII";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // Forms08Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 404);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.txtpuntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsimbolos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.label1);
            this.Name = "Forms08Char";
            this.Text = "Forms08Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsimbolos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpuntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRecorrer;
    }
}