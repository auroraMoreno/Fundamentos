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
    public partial class Form16TiendaProductos : Form
    {
        public Form16TiendaProductos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String prod = this.txtProducto.Text;
            String item = "";
            
            foreach (object obj in this.lsdTienda.Items)
            {
                item = (string)obj;//parsear 
            }
            if (prod == item)
            {
                this.lsdTienda.SelectedItem = prod;

            }
            else
            {
                this.lsdTienda.Items.Add(prod);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numelementos = this.lsdTienda.SelectedIndices.Count - 1;
            for(int i = numelementos; i >=0; i--)
            {
                int indice = this.lsdTienda.SelectedIndices[i];
                this.lsdTienda.Items.RemoveAt(indice);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lsdTienda.Items.Clear();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            int index = this.lsdTienda.SelectedIndex;
            String prod = this.txtProducto.Text;
            this.lsdTienda.Items[index] = prod;
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            //String items = "";
            foreach(object obj in this.lsdTienda.Items)
            {
                //items += obj;
                this.lstAlmacen.Items.Add(obj);
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            foreach(object obj in this.lsdTienda.SelectedItems)
            {
                this.lstAlmacen.Items.Add(obj);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string item = (string)this.lstAlmacen.SelectedItem;
            this.lstAlmacen.Items.Insert(index - 1, this.lstAlmacen.SelectedItem);
            this.lstAlmacen.Items.RemoveAt(index);
        }
    }
}
