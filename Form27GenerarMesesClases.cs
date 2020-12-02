using ProyectoClases;
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
    public partial class Form27GenerarMesesClases : Form
    {
        public Form27GenerarMesesClases()
        {
            InitializeComponent();
           
            DateTime fecha = DateTime.Parse("01/01/2020");
            this.lstMeses.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                String mes = fecha.ToString("MMMM");
                this.lstMeses.Items.Add(mes + " ");
                fecha = fecha.AddMonths(1);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Mes mesClase = new Mes();
            Random rnd = new Random();
            mesClase.Maxima = rnd.Next(0, 30);
            mesClase.Minima = rnd.Next(0, 30);
            mesClase.Media = (mesClase.Maxima + mesClase.Minima) / 2;
            mesClase.Nombre = this.lstMeses.SelectedItem.ToString();
            this.txtNombre.Text = mesClase.Nombre;
            this.txtMaxima.Text = mesClase.Maxima.ToString();
            this.txtMinima.Text = mesClase.Minima.ToString();
            this.txtMedia.Text = mesClase.Media.ToString();
        }
    }
}
