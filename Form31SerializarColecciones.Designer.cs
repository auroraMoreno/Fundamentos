namespace Fundamentos
{
    partial class Form31SerializarColecciones
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
            this.label3 = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnGuardarProductos = new System.Windows.Forms.Button();
            this.btnLeerProductos = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Productos";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(461, 52);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(4);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(169, 180);
            this.lstProductos.TabIndex = 16;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // btnGuardarProductos
            // 
            this.btnGuardarProductos.Location = new System.Drawing.Point(221, 175);
            this.btnGuardarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarProductos.Name = "btnGuardarProductos";
            this.btnGuardarProductos.Size = new System.Drawing.Size(110, 46);
            this.btnGuardarProductos.TabIndex = 15;
            this.btnGuardarProductos.Text = "Guardar Productos";
            this.btnGuardarProductos.UseVisualStyleBackColor = true;
            this.btnGuardarProductos.Click += new System.EventHandler(this.btnGuardarProductos_Click);
            // 
            // btnLeerProductos
            // 
            this.btnLeerProductos.Location = new System.Drawing.Point(221, 112);
            this.btnLeerProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeerProductos.Name = "btnLeerProductos";
            this.btnLeerProductos.Size = new System.Drawing.Size(110, 47);
            this.btnLeerProductos.TabIndex = 14;
            this.btnLeerProductos.Text = "Leer Producto";
            this.btnLeerProductos.UseVisualStyleBackColor = true;
            this.btnLeerProductos.Click += new System.EventHandler(this.btnLeerProductos_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(221, 60);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(110, 46);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar Producto";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(36, 175);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(142, 22);
            this.txtPrecio.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 83);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // Form31SerializarColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnGuardarProductos);
            this.Controls.Add(this.btnLeerProductos);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form31SerializarColecciones";
            this.Text = "Form31SerializarColecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnGuardarProductos;
        private System.Windows.Forms.Button btnLeerProductos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}