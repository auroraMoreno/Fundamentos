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
    public partial class Form13ColeccionGrafica : Form
    {
        public Form13ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //cogemos elemento de caja txt
            String elem = this.txtelemento.Text;
            //la coleccion dodne vamosa insertar es items: (coleccion grafica)
            //debemos averiguar el tipo de items 
            //con items de [] (como con controls)
            //que es eso de items:
            this.lstelementos.Items.Add(elem); //propiedad de coleccion si abor [] poen lo que devulve pide un obj (cualquier clase) es de tipo obj
                                               //guardar cualqueir cosa
            this.txtelemento.SelectAll(); //selecciono el contenido de la caja
            this.txtelemento.Focus(); //y le envia el foco (no es importante) 

        }

        //cuando seleccionamos un lemento quiero ver en las labl la pos y elemto seleccionado
        //selected index y selecteditem 
        //Cuadno seleccionemos en el listbox (doble click al listbox) 
        private void lstelementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //evento por defecto ^
            this.lblposicion.Text =
                "Posicion del elementos: " + this.lstelementos.SelectedIndex; //da el index
            this.lblseleccionado.Text = "Seleccionado: " + this.lstelementos.SelectedItem; //da el "nombre"

        }

        //limpiar: eliminar toda la coleccion 

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //eliminams todos los elementos de la coleccion
            this.lstelementos.Items.Clear(); 
        }

        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //para eliminar elementos indivudaules tenemos 2 metodos diferentes: 
            //.Remove(obj) 
            //.Remove(indice) 
            //los dos hacen lo mismo, eliminan elementos de la coleccion
            //si tengo obj pues le paso el obj y si tengo el indice pues el idce
            //si hubiera repe eleiminaria 1 solo 
            //tenemos un name repetido: 2 anas, quiero eliminar el 2 pero si aplico remove eliminará la primer a coincidencia no la que yo quier
            //en este caso es más eficiciente eliminar por indice. Si yo le digo remove(ana) quitará la primera pos 
            //los indices entonces no se repiten 


            //uso removeAt 
            int indice = this.lstelementos.SelectedIndex; //cojo el elemento seleccionado 
            //de donde eliminar de la coleccion items: 
            this.lstelementos.Items.RemoveAt(indice); //el listbox solo nos está ayudando a verlo mejor lo de las colecciones

        }

        //modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //necesito el index del elelemto que yo necesite
            int index = this.lstelementos.SelectedIndex; //coge el index 
            String elem = this.txtelemento.Text; //cogemos el contendio de la caja para modificar
            //Acedo al elelemtno que yo quiera modifcar, atraves de la coleccion
            this.lstelementos.Items[index] = elem; //accedemo al elemento a mod y cambiamos su interio

        }
        //la coleccion se reposiciona si eliminamos uno, cuando add hace un hueco y se reposiciona pa addearlo 
    }
}
