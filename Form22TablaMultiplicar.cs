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
        int mult; 
        public Form22TablaMultiplicar()
        {
            InitializeComponent();
            this.txtbox = new List<TextBox>();
            foreach(Control control in this.panel1.Controls) {
                if(control is TextBox)
                {
                    this.txtbox.Add((TextBox)control);
                }
            }

          
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);

            for(int i=1; i < this.txtbox.Count; i++)
            {
                mult = num * i;
            }

            foreach(TextBox txt in this.txtbox)
            {
                txt.Text = mult.ToString();
            }
       
        }
    }
}
