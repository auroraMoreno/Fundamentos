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
    public partial class Form11ValidarISBN : Form
    {
        public Form11ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            //8441513929
            String txtnumeros = this.txtISBN.Text;
            int mult = 0;

            for (int i=0; i<txtnumeros.Length; i++)
            {
                char character = txtnumeros[i];
                int numero = int.Parse(character.ToString());
                int resultado = (i + 1) * numero;
                mult += resultado;
            }

            if(mult % 11 == 0) {
                this.lblresultado.Text = "ISBN Correcto";
            }
            else
            {
                this.lblresultado.Text = "Incorrecto";
            }
        }
    }
}
