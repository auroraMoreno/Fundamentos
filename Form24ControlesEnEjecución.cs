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
    public partial class Form24ControlesEnEjecución : Form
    {
        public Form24ControlesEnEjecución()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            //dependiendo de donde yo quiera ponerlos tengo uqe darles un posicionamient
            int posx = 10;

            //generamos 5 checkbox 
        
            for (int i= 1; i <= 5; i++)
            {
                //Instanciamos control checkbox DENTRO del bucle bc queremos 5 new controles
                CheckBox chk = new CheckBox();
                chk.Text = random.Next(1, 50).ToString();
                chk.AutoSize = true;
                chk.Location = new Point(posx,10);
                posx += 70;
                this.panel1.Controls.Add(chk);
                chk.CheckedChanged += RealizarOperacion; //añadimos el evento a cada check
            }

        }

        private void RealizarOperacion(object sender, EventArgs e)
        {
            int valor = int.Parse(this.txtValor.Text); //cogemos el valor de la caja de texto 
            //recuperar el control check que está haciendo la llamada con sender
            CheckBox chk = ((CheckBox)sender);
            //recuperamos el num del checkbox
            int num = int.Parse(chk.Text);
            if(chk.Checked == true)
            {
                valor += num;
            }
            else
            {
                valor -= num;
            }

            this.txtValor.Text = valor.ToString();
        }

       
    }
}
