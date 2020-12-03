using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form31SerializarColecciones : Form
    {
        XmlSerializer serial;
        Productos productos;
        public Form31SerializarColecciones()
        {
            InitializeComponent();
            //instanciamos el serializador para idnicar que vamos a alamcenar objetos productos de una coleccion
            this.serial = new XmlSerializer(typeof(Productos));
            this.productos = new Productos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre = this.txtNombre.Text;
            prod.Precio = int.Parse(this.txtPrecio.Text);
            this.productos.Add(prod);
            this.PintarProductos();
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";
            this.txtNombre.Focus();
            
        }
        private void PintarProductos()
        {
            this.lstProductos.Items.Clear();
            foreach(Producto prod in this.productos)
            {
                this.lstProductos.Items.Add(prod.Nombre);
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstProductos.SelectedIndex != -1)
            {
                int indice = this.lstProductos.SelectedIndex;
                Producto prod = this.productos[indice]; //comprobar esto
                this.txtNombre.Text = prod.Nombre;
                this.txtPrecio.Text = prod.Precio.ToString();
            }
        }

        private async void btnGuardarProductos_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listaproductos.xml");
            this.serial.Serialize(writer, this.productos);
            await writer.FlushAsync();
            writer.Close();
            this.productos.Clear();
            this.lstProductos.Items.Clear();
        }

        private void btnLeerProductos_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaproductos.xml");
            this.productos = (Productos)this.serial.Deserialize(reader);
            reader.Close();
            this.PintarProductos();
        }
    }
}
