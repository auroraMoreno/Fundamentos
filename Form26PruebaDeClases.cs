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


        //9:52 
        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            this.lstDatos.Items.Clear();
            //toda clase debemos instanciarla
            Persona person = new Persona(); //no podemos hacer esto sin namespace, agregar a este proyecto las refs del otro
            person.Nombre = "Adrian"; //dentro del propio set hace un set
            person.Edad = 13;
            person.Genero = TipoGenero.Femenino;
            person.Nacionalidad = Paises.Francia;
            person[0] = "Ojos claros";
            person[1] = "Mandibula cuadrada";
            //person.Domicilio.Calle = "Calle Pez"; //da error, que es null Domicilio (10:55)
            //person.DomicilioVacaciones.Ciudad = "Marina D'or";
            //para que no de error debemos instanciar la clase 
            person.Domicilio = new Direccion();
            person.Domicilio.Calle = "Calle Pez";
            this.lstDatos.Items.Add("Casa " + person.Domicilio.Calle);
            //this.lstDatos.Items.Add("vaciones: " + person.DomicilioVacaciones.Ciudad);
            this.lstDatos.Items.Add("Nombre: " + person.Nombre);
            this.lstDatos.Items.Add("Edad: " + person.Edad); //13:56
            this.lstDatos.Items.Add("Nacionalidad: " + person.Nacionalidad);
            this.lstDatos.Items.Add("Genero: " + person.Genero);
            this.lstDatos.Items.Add("Descripcion: " + person[1]);
            this.lstDatos.Items.Add("Completo " + person.GetNombreCompleto(true)); //sale que hay 4 formas (ver captura)
            person.DomicilioVacaciones = new Direccion("Calle", "alicante", 28033);
             //9:40
            //las enumeraciones simepre habria que ocntrolar todas las posibilades para que nos de los valores 
            //this.btnCrearPersona.TextAlign //las enumeraciones van fuera de la (9:25)
            
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            //cuando creemos un empleado vamos a dibujarlo
            this.lstDatos.Items.Clear();
            Empleado emp = new Empleado();
            emp.Nombre = "Empleado";
            this.lstDatos.Items.Add("datos: " + emp.GetNombreCompleto());
            //13:57
            Empleado empleado = new Empleado("Emp", "Emp");
            //emp.SalarioMinimo = 5000; //no quiero hacer esto
            Director dire = new Director();
            this.lstDatos.Items.Add("dire: " + dire.);
        }
    }
}
