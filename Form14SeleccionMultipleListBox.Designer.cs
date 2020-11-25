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
            this.lblseleccionados.Location = new System.Drawing.Point(34, 392);
            this.lblseleccionados.Name = "lblseleccionados";
            this.lblseleccionados.Size = new System.Drawing.Size(112, 17);
            this.lblseleccionados.TabIndex = 19;
            this.lblseleccionados.Text = "lblseleccionados";
            // 
            // lblindices
            // 
            this.lblindices.AutoSize = true;
            this.lblindices.Location = new System.Drawing.Point(31, 354);
            this.lblindices.Name = "lblindices";
            this.lblindices.Size = new System.Drawing.Size(66, 17);
            this.lblindices.TabIndex = 18;
            this.lblindices.Text = "lblindices";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(470, 112);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(245, 112);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(245, 56);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(246, 22);
            this.txtelemento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Elementos";
            // 
            // lstelementos
            // 
            this.lstelementos.FormattingEnabled = true;
            this.lstelementos.ItemHeight = 16;
            this.lstelementos.Location = new System.Drawing.Point(31, 56);
            this.lstelementos.Name = "lstelementos";
            this.lstelementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstelementos.Size = new System.Drawing.Size(208, 276);
            this.lstelementos.TabIndex = 10;
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(348, 112);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(94, 23);
            this.btnSeleccionados.TabIndex = 20;
            this.btnSeleccionados.Text = "Seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // Form14SeleccionMultipleListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 495);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.lblseleccionados);
            this.Controls.Add(this.lblindices);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstelementos);
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