using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado : Persona //no hay herencia multiple 
    {
        #region CONSTRUCTORES
        //siempre lee est pero si le pongo :base me da a legir cual ctor queiro que lea de la clase perosna 
        public Empleado() 
            :base()
        {
            //Un ctor nunca sustituye, simepre se relizan todos los contrustores en cascada 
            //ver onenote paco 
            Debug.WriteLine("constructor vacio empleado");
            this.SalarioMinimo = 800; 
        }
        public Empleado(String nombre, String apellidos)
            :base(nombre,apellidos)
        {
            Debug.WriteLine("ctor empelado con param");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #endregion

        #region PROPIEDADES
        //public int SalarioMinimo { get; set; }
        //internal int SalarioMinimo { get; set; } //asi no lo ve el form pero si las demás clases de este pryecto
        internal int SalarioMinimo { get; set; }
        #endregion
        //metodo para poder ver el salario minimo en el formulario 


    }
}
