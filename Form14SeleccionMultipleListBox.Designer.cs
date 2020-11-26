namespace Fundamentos
{
    partial class Form14SeleccionMultipleListBox
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
            this.lblseleccionados = new System.Windows.Forms.Label();
            this.lblindices = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstelementos = new System.Windows.Forms.ListBox();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblseleccionados
            // 
            this.lblseleccionados.AutoSize = true;
            this.lblseleccionados.Location = new System.Drawing.Point(26, 318);
            this.lblseleccionados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblseleccionados.Name = "lblseleccionados";
            this.lblseleccionados.Size = new System.Drawing.Size(85, 13);
            this.lblseleccionados.TabIndex = 19;
            this.lblseleccionados.Text = "lblseleccionados";
            // 
            // lblindices
            // 
            this.lblindices.AutoSize = true;
            this.lblindices.Location = new System.Drawing.Point(23, 288);
            this.lblindices.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblindices.Name = "lblindices";
            this.lblindices.Size = new System.Drawing.Size(50, 13);
            this.lblindices.TabIndex = 18;
            this.lblindices.Text = "lblindices";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(352, 91);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 19);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(184, 91);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(56, 19);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(184, 46);
            this.txtelemento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(186, 20);
            this.txtelemento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Elementos";
            // 
            // lstelementos
            // 
            this.lstelementos.FormattingEnabled = true;
            this.lstelementos.Location = new System.Drawing.Point(23, 46);
            this.lstelementos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstelementos.Name = "lstelementos";
            this.lstelementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstelementos.Size = new System.Drawing.Size(157, 225);
            this.lstelementos.TabIndex = 10;
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(261, 91);
            this.btnSeleccionados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(70, 19);
            this.btnSeleccionados.TabIndex = 20;
            this.btnSeleccionados.Text = "Seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // Form14SeleccionMultipleListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 402);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.lblseleccionados);
            this.Controls.Add(this.lblindices);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstelementos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form14SeleccionMultipleListBox";
            this.Text = "Form14SeleccionMultipleListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblseleccionados;
        private System.Windows.Forms.Label lblindices;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstelementos;
        private System.Windows.Forms.Button btnSeleccionados;
    }
}