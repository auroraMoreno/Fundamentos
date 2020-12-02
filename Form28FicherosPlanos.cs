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

namespace Fundamentos
{
    public partial class Form28FicherosPlanos : Form
    {
        public Form28FicherosPlanos()
        {
            InitializeComponent();
        }

        //le añade async
        private async void btnGuardarFichero_Click(object sender, EventArgs e)
        {
            //mirar qués es 
            SaveFileDialog save = new SaveFileDialog(); //mostrar un elemento modal de un dialogo con una respues
            //de esa resupuesta que tenemos ... (10:20)
            //Van a devovler dialogResult y nos la da un método que es: showDialog()
            DialogResult respuesta = save.ShowDialog(); 
            if(respuesta == DialogResult.OK)
            {
                String path = save.FileName; //ofrece la ruta del fichero
                //vamos atrbajar con txt plano
                //la clase FileInfo sirve para manejar cualquier tipo de archivo
                //ofrece info de fichero: cuando fue creado, modificado, su contenido 
                FileInfo file = new FileInfo(path); //se le pasa la ruta (el filename) 
                //apartir del file info podemos crear objs para leer bytes o planos 
                //file. //con esto veo las caracteristicas del fichero y las puedo recuperar
                //para leerlo como txt plano tenemos:
                //file.CreateText //devuelve un obj para leerlo un texto plano(10:26)
                        //vamos a usar using para crear el obj, usarlo y detruilo a la vez
                        //dependiendo del obj tendré que hacer x cosa 
                //sintaxis using podemos...
                using(TextWriter writer = file.CreateText())
                {
                    //Escribir ? lo que nos pongan en la caja de txt 
                    //writer.Write(this.txtTexto.Text);
                    //await writer.WriteAsync(this.txtTexto.Text);
                    await writer.WriteAsync(this.GetStringNombre());
                    //independiente a texto plano o write al escribir debemos:
                    //liberar el flujo de memoria 
                    //cerrar el fichero 
                    //si no hago esto escribe pero a veces no lo tiene 
                    //writer.Flush();
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstNombres.Items.Clear();
                this.txtTexto.Text = ""; //limpiamos la caja 
            }

        }

        //le añado la palabra async (no todas las clases traen async) 
        private async void btnLeerFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); //para poder leer el fichero
            //le decimos la respuesta: 
            DialogResult respuesta = open.ShowDialog();
            //hacemos if para indicar si la respuesta es positiva
            if(respuesta == DialogResult.OK)
            {
                //capturamos la ruta
                String path = open.FileName;
                FileInfo file = new FileInfo(path); //le pasamos la ruta
                //hacemos el using y nos creamos en lugar de text writer un text reader 
                using(TextReader reader = file.OpenText())
                {
                    //10:33 y 10:39
                    //String contenido = reader.ReadToEnd();
                    String contenido = await reader.ReadToEndAsync();
                    //debemos cerrar el reader
                    reader.Close();
                    this.txtTexto.Text = contenido;
                    this.SetStringNombre(contenido);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNombre.Text;
            this.lstNombres.Items.Add(nombre);
            this.txtNombre.Text = "";
            this.txtNombre.Focus();
        }

        //metodo que devuelva los elelmtos que haya dentro de la lista

        public String GetStringNombre()
        {
            String datos = "";
            foreach(String nombre in this.lstNombres.Items)
            {
                //por cad nombre que recorremos lo guardamos:
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        public void SetStringNombre(String data)
        {
            //en data yo voy a recibir lo que tenga en el fichero
            //data.Split() //devuelve un array todos los nombres separados por coma 
            String[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();
            foreach (String n in nombres)
            {
                this.lstNombres.Items.Add(n);
            }
        }
    }
}
