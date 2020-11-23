using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpulsar_Click(object sender, EventArgs e)
        {
            //cuando pulsemos el btn 
            //propiedades de tipo primitivo
            txtcaja.Text = "Soy texto";
            //La palabra clave this indica la clase sobre la que estamos trabajando
            //es opcional; si no lo pongo por defecto recupera el nombre de var por cercania
            this.txtcaja.Width = 400;
            //Propiedades de objetos 
            //para ellas debemos crear obj de la clase con new Clase()
            //cambiar tamamno de boton. Propiedad:size
            this.btnpulsar.Size = new Size(350, 250);
            //algunas clases no se crean (menos comun) si no que se utilizan directamente 
            this.BackColor = Color.Gold;
            //Enumeraciones (en amarillo) es una serie de posibilidades para una propiedad 
            //son tipos int que se muestran como string 
            this.txtcaja.TextAlign = HorizontalAlignment.Right;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
