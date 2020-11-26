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

        //para que funcione usar control
        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            //lo querio es dibujar en el label los items y por otro los index 
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
            //this.lstelementos.SelectedItems[] //de la clase object (9:10)
            foreach(object obj in this.lstelementos.SelectedItems)
            {
                //en ese string (items) guardamos el obj
                items += obj + ",";
            }
            //pintamos:
            this.lblindices.Text = indices.Trim(',');
            //se puede hacer con abstraccion, pero ahora me centro en tipo especifico y veremos porque object
            this.lblseleccionados.Text = items.Trim(',');
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Vamos a recorrer todos los index seleccionados, es decir recorremos selected indice
            //cuando estemos con cada indice que recuperemos queremos borrarlo
            //si lo borramos de sIndex solo se borra del selecionado
            //todos los elelemtos de la coleccion esta en item, ahi está el "objeto" de ahi hay que borrar
            //sInd y sItem solo como herramienta
            //foreach(int i in this.lstelementos.SelectedIndices)
            //{
            //    //acedemos a coleccion items y le decimo que elimine el seleccionado 
            //    this.lstelementos.Items.RemoveAt(i); //el que corresponde al indice se elimina

            //    //selec: b y a (item) si coge la a se elimina y si coge 2 solo elimina 1 de los seleccionado o no elimina todos
            //    //esto pasa bc: 
            //    //ahora selec la a y num 0 y lo va a elomonar
            //    //el siguiente elemento se reposiciona el index y si quiere elimar el 0 y 4 al eliminar primero el 
            //    //0 el 4 ya no existe a que pasa a ñ3
            //    // hay que eliminar del finalal principio

            //}
            //siempre que eliminemos varios elementos de una coleccion 
            //debemos realizar la accion a la inversa
            //por el ultimo elelemto para que el resposiconamiento de indeces no afecte al orden 

            int numelementos = this.lstelementos.SelectedIndices.Count - 1; //coge el ultimo indice (9:33)
            //bucle contador obligatorio para borrar, el foreach es solo recorrer
            for(int i = numelementos; i>=0; i--) //bucle del final al principio 
            {
                //rcupero cada indice seleccionado
                int indseleccionado = this.lstelementos.SelectedIndices[i]; //de la lista de indice seleccionado coge cada 1 
                this.lstelementos.Items.RemoveAt(indseleccionado); //lo borra 

            }
            //un array jamas se reordena (pregunta de Gabri) 
        }
    }
}
