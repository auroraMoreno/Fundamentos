namespace Fundamentos
{
    partial class Form07DateTime
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
            this.txtfechaactual = new System.Windows.Forms.TextBox();
            this.chkCambiarFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.rdbaños = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // txtfechaactual
            // 
            this.txtfechaactual.Location = new System.Drawing.Point(35, 57);
            this.txtfechaactual.Name = "txtfechaactual";
            this.txtfechaactual.Size = new System.Drawing.Size(348, 20);
            this.txtfechaactual.TabIndex = 1;
            // 
            // chkCambiarFormato
            // 
            this.chkCambiarFormato.AutoSize = true;
            this.chkCambiarFormato.Location = new System.Drawing.Point(35, 99);
            this.chkCambiarFormato.Name = "chkCambiarFormato";
            this.chkCambiarFormato.Size = new System.Drawing.Size(105, 17);
            this.chkCambiarFormato.TabIndex = 2;
            this.chkCambiarFormato.Text = "Cambiar Formato";
            this.chkCambiarFormato.UseVisualStyleBackColor = true;
            this.chkCambiarFormato.CheckedChanged += new System.EventHandler(this.chkCambiarFormato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.btnIncrementar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbaños);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbDias);
            this.groupBox1.Location = new System.Drawing.Point(35, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones Fecha";
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Location = new System.Drawing.Point(6, 19);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(48, 17);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Días";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.Location = new System.Drawing.Point(6, 42);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(56, 17);
            this.rdbMeses.TabIndex = 1;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses";
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbaños
            // 
            this.rdbaños.AutoSize = true;
            this.rdbaños.Location = new System.Drawing.Point(6, 68);
            this.rdbaños.Name = "rdbaños";
            this.rdbaños.Size = new System.Drawing.Size(49, 17);
            this.rdbaños.TabIndex = 2;
            this.rdbaños.TabStop = true;
            this.rdbaños.Text = "Años";
            this.rdbaños.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(119, 62);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(75, 23);
            this.btnIncrementar.TabIndex = 4;
            this.btnIncrementar.Text = "Mostrar Fecha";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(35, 307);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(158, 346);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(35, 13);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "Datos";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(119, 36);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(101, 20);
            this.txtIncremento.TabIndex = 5;
            // 
            // Form07DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(586, 421);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCambiarFormato);
            this.Controls.Add(this.txtfechaactual);
            this.Controls.Add(this.label1);
            this.Name = "Form07DateTime";
            this.Text = "Form07DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfechaactual;
        private System.Windows.Forms.CheckBox chkCambiarFormato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbaños;
        private System.Windows.Forms.RadioButton rdbMeses;
        private System.Windows.Forms.RadioButton rdbDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevaFecha;
        private System.Windows.Forms.Label lblDatos;
    }
}