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
    public partial class Form17MetodoReferencia : Form
    {
        //metodos van dentro de la clase
        public Form17MetodoReferencia()
        {
            InitializeComponent();
        }

        //creams un metodo para comprobar valor de tipos wrapper 
        //por ahora void
        //metodo multiplca *2
        void DobleNumero(int num)
        {
      
            num = num * 2; 
        }

        //metod que recibe una clase por referencia
        //vamos a visualizar q lo va a cambiar
        void CambiarColor(Button btn)
        {
            //boton no es wrapper es una clase
            btn.BackColor = Color.Fuchsia;
        }

        //esto no es normal:
        //un metodo que recibe un wrapper o primitivo
        //y lo usa como referencia 
        //par que apunten al mismo espacio de memo
        void DobleReferencia(ref int num)
        {
            num = num * 2;
        }
        
           //si necesitamos devovler algo a la llamada no usamos void 
        int GetDoble(int num)
        {
            //siempre devovler valor 
            //dentro de un bucle if sigue dando error 
            //tenemor que poner un retrun siempree, aunque sea valor por defecto
            return num * 2;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            //cogemos num de la caja de txt num 
            int numero = int.Parse(this.txtNumero.Text);
            //llamamos al metodo con la variable por valor (13:56)
            //solo recibe el valor pero no lo multiplica (eso quiere decir por valor)
            //this.DobleNumero(numero);
            //llamamos al metodo que recibe un obj por ref
            this.CambiarColor(this.btnLlamar);
            //lo mismo que odble de dnum solo cambia el tipado
            //si deseamos enviar referencia debemos incluir la palabra ref
            //this.DobleReferencia(ref numero);
            int doble = this.GetDoble(numero); //asi es como hay que hacaerlp
            this.lblresultado.Text = "Doble " + doble;
        }
    }
}
