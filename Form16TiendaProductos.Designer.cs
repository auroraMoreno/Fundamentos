namespace Fundamentos
{
    partial class Form16TiendaProductos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lsdTienda = new System.Windows.Forms.ListBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModifcar = new System.Windows.Forms.Button();
            this.btnSeleccionarTodos = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstAlmacen = new System.Windows.Forms.ListBox();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tienda";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(26, 46);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(122, 20);
            this.txtProducto.TabIndex = 2;
            // 
            // lsdTienda
            // 
            this.lsdTienda.FormattingEnabled = true;
            this.lsdTienda.Location = new System.Drawing.Point(194, 62);
            this.lsdTienda.Name = "lsdTienda";
            this.lsdTienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsdTienda.Size = new System.Drawing.Size(126, 199);
            this.lsdTienda.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(26, 73);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(26, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(26, 161);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "btnLimpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModifcar
            // 
            this.btnModifcar.Location = new System.Drawing.Point(26, 191);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(75, 23);
            this.btnModifcar.TabIndex = 7;
            this.btnModifcar.Text = "Modificar";
            this.btnModifcar.UseVisualStyleBackColor = true;
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(365, 96);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(75, 37);
            this.btnSeleccionarTodos.TabIndex = 8;
            this.btnSeleccionarTodos.Text = "Selecc. Todos";
            this.btnSeleccionarTodos.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(354, 161);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(86, 23);
            this.btnSeleccion.TabIndex = 9;
            this.btnSeleccion.Text = "Seleccionados";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alamacén";
            // 
            // lstAlmacen
            // 
            this.lstAlmacen.FormattingEnabled = true;
            this.lstAlmacen.Location = new System.Drawing.Point(482, 62);
            this.lstAlmacen.Name = "lstAlmacen";
            this.lstAlmacen.Size = new System.Drawing.Size(124, 199);
            this.lstAlmacen.TabIndex = 11;
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(555, 267);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(75, 23);
            this.btnBajar.TabIndex = 12;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(451, 267);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 23);
            this.btnSubir.TabIndex = 13;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // Form16TiendaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.lstAlmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.btnSeleccionarTodos);
            this.Controls.Add(this.btnModifcar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lsdTienda);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form16TiendaProductos";
            this.Text = "Form16TiendaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ListBox lsdTienda;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModifcar;
        private System.Windows.Forms.Button btnSeleccionarTodos;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstAlmacen;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
    }
}