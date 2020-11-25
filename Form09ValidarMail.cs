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
    public partial class Form09ValidarMail : Form
    {
        public Form09ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            String email = this.txtemail.Text; //cogemos email de la caja de texto 
            //vamos a escribir en el lbl mensaje lo que falta para ir probando metodos de clase string
            //solo vamos a poner uno de ellos a la vez, si no habría que concatenar lo que hubiera
            //no pone un sumatorio de fallos 
            //esto se podria hacer con expresiones regulares 
            if (email.Contains("@") == false) //si no tiene arroba 
            {
                this.lblmensaje.Text = "no existe @";
            }else if(email.StartsWith("@") || email.EndsWith("@")) //si el email empieza o finaliza con @
            {
                this.lblmensaje.Text = "@al incio o final no válida";
            }else if (email.IndexOf("@") != email.LastIndexOf("@")) //buscamos arroba + sobrecarga de indexOf si la posicion es la misma, es que solo hay 1 
            {
                //indexOF empieza buscar desde izq y el last desde la derecha, si la posicion coincide solo 1 y si no es que hay más de 1 
                this.lblmensaje.Text = "Existe mas de una @";
            }else if (email.Contains(".") == false) 
            {
                //si no existe un punto: 
                this.lblmensaje.Text = "No existe ."; 
            }else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                //si buscando el punto su poscion es mayor (desd el final) a la de @ 
                this.lblmensaje.Text = "Debe Punto despues de la @";
            }
            else
            {
                //posicion ultimo punto que exista (empieza desde la derecha) 
                int ultimopunto = email.LastIndexOf(".");
                //captruamos txt del dominio:
                String dominio = email.Substring(ultimopunto + 1); //captura las letras del dominio
                if(dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblmensaje.Text = "MAil bien";
                }
                else
                {
                    this.lblmensaje.Text = "Dominio de 2 a 4 letras";
                }
            }
        }
    }
}
