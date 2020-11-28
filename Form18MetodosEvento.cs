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
    public partial class Form18MetodosEvento : Form
    {
        public Form18MetodosEvento()
        {
            InitializeComponent();
        }

        private void lblraton_MouseHover(object sender, EventArgs e)
        {
            //event args no trae info 
            
        }

        private void lblraton_MouseMove(object sender, MouseEventArgs e)
        {
            //trae info el event args bc es MouseEventArgs (herencia de eventargs) 
            //para verlo e. 
            //pintamos en el lbl las coordenadas
            this.lblraton.Text = "X: " + e.X + "Y: " + e.Y;
        }

        private void txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //escribir solo num en las cajas
            //en e key char (character oulsado) tipo dato char
            //handled (manejo yo evento, se comporta como yo quier)
            //forma de indicar si es num o no num? isDigit 
            //Deseamos incluir la tecla de borrar: 
            //hay que aislarla 
            //con ke char puedo preguntar si es arroba o guion... pero no puedo hacerlo con la tcha de borrar
            //lo que sí es recuperar es codigo ascii de una tecla 
            //dos opciones: pregutnar a googl el codigo ascii de la tecla back
            //opcion 2: enumeracion que nos devulve todos los codigosde ascii:
            //tecla back = 8:
            char c = (char)8; //Cojo codigo ascii, lo converto a char y devuelve la tecla back 
            //opcion 2: existe una enumeracion que es la enumeracion keys 
            char teclaBack = (char)Keys.Back; //devuelve e lcodigo de las teclas 

            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBack) //9:26: si no es num la tecla que has pulsado o la tecla de borrar no escribes
            {
                e.Handled = true; //manejamos el evetno (9:25)
                    //prop que impide que escribas 
            }
            //con esta lógica ^ podemos preguntar por cualquier techa; 
            //la clase char permite validar y compropobar si alguien me ha enviado un formato mal (para el back)
        

         
        }

        private void txtletras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBack) //9:26: si no es letra la tecla que has pulsado o la tecla de borrar no escribes
            {
                e.Handled = true; //manejamos el evetno (9:25)
                                  //prop que impide que escribas 
            }
        }
    }
}
