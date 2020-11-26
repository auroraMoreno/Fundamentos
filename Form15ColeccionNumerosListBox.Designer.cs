namespace Fundamentos
{
    partial class Form15ColeccionNumerosListBox
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
            this.lstnumeros = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txPares = new System.Windows.Forms.TextBox();
            this.txImpares = new System.Windows.Forms.TextBox();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros";
            // 
            // lstnumeros
            // 
            this.lstnumeros.FormattingEnabled = true;
            this.lstnumeros.Location = new System.Drawing.Point(27, 57);
            this.lstnumeros.Name = "lstnumeros";
            this.lstnumeros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstnumeros.Size = new System.Drawing.Size(120, 186);
            this.lstnumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(160, 59);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(255, 59);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(90, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Impares";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(231, 114);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 7;
            // 
            // txPares
            // 
            this.txPares.Location = new System.Drawing.Point(231, 157);
            this.txPares.Name = "txPares";
            this.txPares.Size = new System.Drawing.Size(100, 20);
            this.txPares.TabIndex = 8;
            // 
            // txImpares
            // 
            this.txImpares.Location = new System.Drawing.Point(231, 200);
            this.txImpares.Name = "txImpares";
            this.txImpares.Size = new System.Drawing.Size(100, 20);
            this.txImpares.TabIndex = 9;
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(361, 59);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionados.TabIndex = 10;
            this.btnSeleccionados.Text = "Suma seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // Form15ColeccionNumerosListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 290);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.txImpares);
            this.Controls.Add(this.txPares);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstnumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form15ColeccionNumerosListBox";
            this.Text = "Form15ColeccionNumerosListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstnumeros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txPares;
        private System.Windows.Forms.TextBox txImpares;
        private System.Windows.Forms.Button btnSeleccionados;
    }
}