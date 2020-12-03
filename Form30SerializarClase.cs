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
using System.Xml.Serialization; //lo primero hacer el using

namespace Fundamentos
{
    public partial class Form30SerializarClase : Form
    {
        XmlSerializer serial; 
        public Form30SerializarClase()
        {
            InitializeComponent();
            //en el momento de instanciar debemos indicar la clase que almacenaremos, en este caso 
            //clase producto 
            //con typeOf o GetType 
            //String dato = "djskfhdsjk";
            ////le digo:
            //dato.GetType(); //me devuelve el objeto type 
            this.serial = new XmlSerializer(typeof(Producto));

        }

        private async void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            //creamos un obj de la clase producto
            Producto producto = new Producto();
            producto.Nombre = this.txtProducto.Text;
            producto.Precio = int.Parse(this.txtPrecio.Text);
            //Para serializar en este caso se utiliza system.IO para serializar el fichero 
            //clase streamReader/Writer 
            StreamWriter writer = new StreamWriter("producto.xml");
            //se va a almacenar en el bin si no le digo ruta 
            //con el metodo seralize del obj xml serial, almacenamos un obj de la clase y genera un 
            //fichero xml con el producto
            //luego automaticamente recuperará ese obj produ
            //EL writer es el vehiculo para escribir el fichero 
            this.serial.Serialize(writer,producto);//pasamos el stream y el objeto prod
            await writer.FlushAsync();
            writer.Close();
            this.txtProducto.Text = "";
            this.txtPrecio.Text = "";
            this.lblInfo.Text = "Datos guardados";
        }

        private void btnLeerProducto_Click(object sender, EventArgs e)
        {
            //necesitamos:
            StreamReader reader = new StreamReader("producto.xml");
            //la deserializacion es automatica
            //envaimos el reader y nos devuelve el obj ya instanciado 
            //usamos el metodo deserialize 
            Producto producto = (Producto)this.serial.Deserialize(reader);
            reader.Close();
            this.txtProducto.Text = producto.Nombre;
            this.txtPrecio.Text = producto.Precio.ToString();
            this.lblInfo.Text = "Producto leido";
        }
    }
}
