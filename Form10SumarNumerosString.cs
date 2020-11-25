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
    public partial class Form10SumarNumerosString : Form
    {
        public Form10SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e){   
            //1+2 = 99 hecho de esta forma 
            //necesitamos el texto de la txt aunqeu sea num son strings:
            String txtnumeros = this.txtsuma.Text;
            //ahora los va a recorrer con bucle de desde 0 hasta lenght, mas tarde con bucles de referencia
            //recorremos todos los caracteres del string: 
            //necesitamos var para ir sumando y inciializarla bc si no da error: 
            int suma = 0; 
            //tipico 1234 == 10 (suma)
            //recorre caracter a caracter los caracteres de txtnuemero:
            for(int i =0; i< txtnumeros.Length; i++)
            {
                //recuperamos cada caracter: 
                char caracter = txtnumeros[i]; //propiedad indizada, cada elemento que hay dentro del obj conjunto
            //convertimos el caracter a numero
            //recupera el codigo ascii en lugar del caracter literal (ver min 9:47)
            //int num = caracter;
            //en el char lo que vemos es que hace la conversion solo ( de momento) 

                int num = int.Parse(caracter.ToString()); //hay que hacer la conversión directamente (ver 9:47)
                
                //ahora cogemos suma y vamso realizando el sumatorio mas el num:
                suma += num;
            }
            this.lblresultado.Text = suma.ToString(); //pintamos los caracteres 

        }
    }
}
