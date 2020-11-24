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
    public partial class Form06CalcularDiaNacimiento : Form
    {
        public Form06CalcularDiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int año = int.Parse(txtaño.Text);
            
            if(mes == 1)
            {
                mes = 13;
                año = año - 1;
            }else if (mes == 2)
            {
                mes = 14;
                año = año - 1;
            }

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = año / 4;
            int op3 = año / 100;
            int op4 = año / 400;
            int op5 = dia + mes * 2 + año + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - op6 * 7;

            switch (op7)
            {
                case 0:
                    this.lbldia.Text = "Sábado";
                    break;
                case 1:
                    this.lbldia.Text = "Domingo";
                    break;
                case 2:
                    this.lbldia.Text = "Lunes";
                    break;
                case 3:
                    this.lbldia.Text = "Martes";
                    break;
                case 4:
                    this.lbldia.Text = "Miércoles";
                    break;
                case 5:
                    this.lbldia.Text = "Jueves";
                    break;
                case 6:
                    this.lbldia.Text = "Viernes";
                    break;
                default:
                    this.lbldia.Text = "Esperando numero";
                    break;
                       
            }
       
        }
    }
}
