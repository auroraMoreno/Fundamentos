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
    public partial class Form26PruebaDeClases : Form
    {
        public Form26PruebaDeClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            //toda clase debemos instanciarla
            Persona person = new Persona(); //no podemos hacer esto sin namespace, agregar a este proyecto las refs del otro
            person.Nombre = "Adrian"; //dentro del propio set hace un set
            person.Edad = 13;
            this.lstDatos.Items.Add("Nombre: " + person.Nombre);
            this.lstDatos.Items.Add("Edad: " + person.Edad); //13:56
        }
    }
}
