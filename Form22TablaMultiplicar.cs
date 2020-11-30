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
    public partial class Form22TablaMultiplicar : Form
    {
        List<TextBox> txtbox;
        public Form22TablaMultiplicar()
        {
            InitializeComponent();
            this.txtbox = new List<TextBox>();
            //en controls la ultima es la primera* (antes no nos importaba el orden)
            foreach(Control control in this.panel1.Controls) {
                if(control is TextBox)
                {
                    this.txtbox.Add((TextBox)control);
                }
            }

            //parar reordenar: 
            this.txtbox.Reverse(); //así irá del primero al ultimo 

          
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);

            //asi sale de arriba a abajo*
            for(int i=1; i < this.txtbox.Count; i++)
            {
                int mult = num * i;
                this.txtbox[i - 1].Text = mult.ToString();
            }

       
        }
    }
}
