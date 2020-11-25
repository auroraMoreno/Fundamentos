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
    public partial class Form14SeleccionMultipleListBox : Form
    {
        public Form14SeleccionMultipleListBox()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //insertar
            String elem = this.txtelemento.Text; //cogemos el elelemtos
            //lo add a la coleccion
            this.lstelementos.Items.Add(elem);
            //pijada de las cajas
            this.txtelemento.SelectAll();
            this.txtelemento.Focus();

        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            //lo querio es dibujar en el labe los items y por otro los index 
            //se crea var indices par adibujar los indeices
            String indices = "";
            //otra var para los items:
            String items = "";
            //las colecciones que vamos a recorrer la primera de ellas va a ser .SelectedIndices para pintar los indices
            //averiguar que tipo de datos tiene esta coleccion:
            //this.lstelementos.SelectedIndices[] //con la ayuda vemos que tieene int 
            foreach(int n in this.lstelementos.SelectedIndices)
            {
                indices += n + ","; //pintamos lo que tenga en su interior 

            }
            // .SelectedItems 
            //averiguar qué tiene esto en su interiro: 
            //this.lstelementos.SelectedItems[]
        }
    }
}
