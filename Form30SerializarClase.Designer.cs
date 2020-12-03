namespace Fundamentos
{
    partial class Form30SerializarClase
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
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.labek2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnLeerProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(73, 90);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(132, 22);
            this.txtProducto.TabIndex = 1;
            // 
            // labek2
            // 
            this.labek2.AutoSize = true;
            this.labek2.Location = new System.Drawing.Point(69, 172);
            this.labek2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labek2.Name = "labek2";
            this.labek2.Size = new System.Drawing.Size(48, 17);
            this.labek2.TabIndex = 2;
            this.labek2.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(73, 208);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // btnLeerProducto
            // 
            this.btnLeerProducto.Location = new System.Drawing.Point(73, 262);
            this.btnLeerProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeerProducto.Name = "btnLeerProducto";
            this.btnLeerProducto.Size = new System.Drawing.Size(100, 50);
            this.btnLeerProducto.TabIndex = 4;
            this.btnLeerProducto.Text = "Leer Producto";
            this.btnLeerProducto.UseVisualStyleBackColor = true;
            this.btnLeerProducto.Click += new System.EventHandler(this.btnLeerProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(211, 262);
            this.btnGuardarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(100, 50);
            this.btnGuardarProducto.TabIndex = 5;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(73, 330);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(45, 17);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "lblinfo";
            // 
            // Form30SerializarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 412);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.btnLeerProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labek2);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form30SerializarClase";
            this.Text = "Form30SerializarClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label labek2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnLeerProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Label lblInfo;
    }
}