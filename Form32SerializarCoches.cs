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
    public partial class Form32SerializarCoches : Form
    {
        XmlSerializer serial;
        Coches coches;
        public Form32SerializarCoches()
        {
            InitializeComponent();
            this.serial = new XmlSerializer(typeof(Coches));
            this.coches = new Coches();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //insertamos en el lst
            Coche coche = new Coche();
            coche.Marca = this.txtMarca.Text;
            coche.Modelo = this.txtModelo.Text;
            //byte[] img2 = Convert.ToByte(this.pictureBox1.Image);
            //coche.Imagen = img2;
            //byte img = Convert.ToByte(coche.Imagen);
            this.coches.Add(coche);
            this.PintarCoches();
            //limpiamos y devovlemos el foco al txt primero
            this.txtMarca.Text = "";
            this.txtModelo.Text = "";
            this.pictureBox1.Image = null;
            this.txtMarca.Focus();

        }

        private void PintarCoches()
        {
            //pintamos los productos insertados en la lst
            this.lstCoches.Items.Clear();
            foreach(Coche c in this.coches)
            {
                this.lstCoches.Items.Add(c.Modelo);
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listacoches.xml");
            this.serial.Serialize(writer, this.coches);
            await writer.FlushAsync();
            writer.Close();
            this.coches.Clear();
            this.lstCoches.Items.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listacoches.xml");
            this.coches= (Coches)this.serial.Deserialize(reader);
            reader.Close();
            this.PintarCoches();
        }

        private void lstCoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstCoches.SelectedIndex != -1)
            {
                int indice = this.lstCoches.SelectedIndex;
                Coche coche = this.coches[indice];
                this.txtMarca.Text = coche.Marca;
                this.txtModelo.Text = coche.Modelo;

            }
        }
    }
}
