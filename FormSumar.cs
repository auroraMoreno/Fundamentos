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
    public partial class FormSumar : Form
    {
        public FormSumar()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //necesitamos los valores de las cajas 
            //son tipo string y necesitamos int 
            //debemos convertir string a int 
            //parsear 
            int num1, num2;
            num1 = int.Parse(this.txtnum1.Text);
            num2 = int.Parse(this.txtnum2.Text);
            int suma = num1 + num2;
            //debemos convertri a string,
            this.lblresultado.Text = suma.ToString();
        }
    }
}
