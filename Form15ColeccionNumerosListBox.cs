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
    public partial class Form15ColeccionNumerosListBox : Form
    {
        public Form15ColeccionNumerosListBox()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for(int i = 0; i < 5; i++)
            {
                this.lstnumeros.Items.Add(rnd.Next(1, 30));
            }
            
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            foreach(object obj in this.lstnumeros.Items)
            {
                sumaTotal += int.Parse(obj.ToString());
            }
            this.txtSuma.Text = sumaTotal.ToString();

            foreach (object obj in this.lstnumeros.Items)
            {
                if(int.Parse(obj.ToString()) % 2 == 0)
                {
                    sumaPares += int.Parse(obj.ToString());
                }
                else
                {
                    sumaImpares += int.Parse(obj.ToString());
                }
            }

            this.txPares.Text = sumaPares.ToString();
            this.txImpares.Text = sumaImpares.ToString();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaPares = 0; 
            int sumaImpares = 0;

            foreach (object obj in this.lstnumeros.SelectedItems)
            {
                sumaTotal += int.Parse(obj.ToString());
            }
            this.txtSuma.Text = sumaTotal.ToString();

            foreach(object obj in this.lstnumeros.SelectedItems)
            {
                if(int.Parse(obj.ToString()) % 2 == 0)
                {
                    sumaPares += int.Parse(obj.ToString());
                }
                else
                {
                    sumaImpares += int.Parse(obj.ToString());
                }
            }
            this.txPares.Text = sumaPares.ToString();
            this.txImpares.Text = sumaImpares.ToString();
        }
    }
}
