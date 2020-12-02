using ProyectoClases; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{

    public partial class Form29FicheroProductos : Form
    {
        List<Producto> productos;
        public Form29FicheroProductos()
        {
            this.productos = new List<Producto>();
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            
            producto.Nombre = this.txtNombre.Text;
            producto.Precio = int.Parse(this.txtPrecio.Text);
            this.lstProductos.Items.Add(producto.Nombre + " " + producto.Precio);
            this.productos.Add(producto);
        }

        private async void btnGuardarProductos_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            DialogResult respuesta = save.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = save.FileName;
                FileInfo file = new FileInfo(path);
                using(TextWriter writer = file.CreateText()){
                    foreach(Producto p in this.productos)
                    {
                        await writer.WriteAsync(p.Nombre + p.Precio);
                    }
                   
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstProductos.Items.Clear();
                this.txtNombre.Text = "";
                this.txtPrecio.Text = "";
            }
        }


        private async void btnLeerProductos_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using(TextReader reader = file.OpenText())
                {
                    String contenido = "";
                    foreach(Producto p in this.productos)
                    {
                        contenido =p.Nombre + " " + p.Precio;
                        contenido = await reader.ReadToEndAsync();
                        this.SetProducto(p);

                    }
                   
                    reader.Close();
                    this.lstProductos.Items.Add(contenido);
                  
                }
            }
        }

        public Producto GetProducto()
        {
            Producto prod =new Producto();
            foreach (Producto p in this.productos)
            {
                prod = p;
            }
            return prod;
        }
        public void SetProducto(Producto data)
        {
            Producto producto = data;
            this.lstProductos.Items.Clear();
            foreach (String p in this.lstProductos.Items)
            {
                this.lstProductos.Items.Add(p);
            }
        }
    }
}
