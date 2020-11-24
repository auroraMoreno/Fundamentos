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
    public partial class Forms08Char : Form
    {
        public Forms08Char()
        {
            InitializeComponent();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 255; i++)
            {
                //queremos convertir cada int a char (la var i a char)
                char character = (char)i;
                
                if(char.IsLetter(character) == true)
                {
                    this.txtletras.Text += character;
                }
                else if(char.IsNumber(character) == true)
                {
                    this.txtnumeros.Text += character;

                }else if(char.IsSymbol(character) == true)
                {
                    this.txtsimbolos.Text += character;

                }else if(char.IsPunctuation(character) == true)
                {
                    this.txtpuntuacion.Text += character;
                }

            }
        }
    }
}
