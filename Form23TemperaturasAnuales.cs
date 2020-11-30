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
    public partial class Form23TemperaturasAnuales : Form
    {
        List<int> tempertaturas;
       
        public Form23TemperaturasAnuales()
        {
            InitializeComponent();
            this.tempertaturas = new List<int>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse("01/01/2020");
            Random rnd = new Random();
            this.lstMeses.Items.Clear();

            for (int i=0; i<12; i++)
            {
                String mes = fecha.ToString("MMMM");
                int aleat = rnd.Next(-5, 40);
                this.lstMeses.Items.Add(mes + " " + aleat);
                this.tempertaturas.Add(aleat);
                fecha = fecha.AddMonths(1);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int max, min, media, suma;
            min = this.tempertaturas[0];
            max = this.tempertaturas[0];
            suma = 0;
            foreach(int t in this.tempertaturas)
            {
                suma += t;
                if(t > max)
                {
                    max = t;
                }

                min = Math.Min(t, min);
            }

            media = suma / this.tempertaturas.Count;
            //falta pintar en los txt
        }
    }
}
