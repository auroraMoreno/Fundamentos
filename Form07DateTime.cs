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
    public partial class Form07DateTime : Form
    {
        public Form07DateTime()
        {
            InitializeComponent();

            this.txtfechaactual.Text = DateTime.Now.ToString();



        }

        private void chkCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            //cambiar fecha a fomrato corto o largo
            DateTime fecha = DateTime.Parse(this.txtfechaactual.Text);
            if(this.chkCambiarFormato.Checked == true)
            {
                this.txtfechaactual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtfechaactual.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtfechaactual.Text);
            if(this.rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }else if(this.rdbMeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }
         
            this.txtNuevaFecha.Text = fecha.ToString();

            this.lblDatos.Text = "Bisiesto: "
                  + DateTime.IsLeapYear(fecha.Year)
                  + "\nDia semana: " + fecha.DayOfWeek
                  + "\nDia año: " + fecha.DayOfYear;
        }
    }
}
