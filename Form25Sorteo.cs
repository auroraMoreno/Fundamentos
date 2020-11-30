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
    public partial class Form25Sorteo : Form
    {
        List<Button> btns;
        public Form25Sorteo()
        {
            this.btns = new List<Button>();
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int posx = 10;
            //int posy = 10;
            //for(int i = 1; i<=4; i++)
            //{
            //    ListView lst = new ListView();
            //    lst.Location = new Point(10, 10);
            //}
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();
                btn.AutoSize = true;
                btn.Text = i.ToString();
                btn.Location = new Point(posx, 10);
                posx += 40;
                btn.MaximumSize = new System.Drawing.Size(20, 20);
                this.panel1.Controls.Add(btn);
                btn.Click += SeleccionarNumero;
              
                
            }
        }

        private void SeleccionarNumero(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            btn.BackColor = Color.Yellow;
            this.btns.Add(btn);
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for(int i=1; i <=6; i++)
            {
                this.lstNumerosPremiados.Items.Add(rnd.Next(1, 10));

               
            }

          for(int i = 1; i < this.lstNumerosPremiados.Items.Count; i++)
            {
                int num = (int)this.lstNumerosPremiados.Items[i];
                foreach(Button b in this.btns)
                {
                    if(num.ToString() == b.Text)
                    {
                        b.BackColor = Color.Green;
                        //poner selected index
                    }
                    else
                    {
                        b.BackColor = Color.Red;
                    }
                }
            }


        }
    }
}
