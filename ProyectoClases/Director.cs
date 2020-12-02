using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 1000; 
        }


        //un metodo sobreescrito sustituye el de la clase base 
        //nunca leerá el método de la clase base
        //* (visualizar cual está sobrescirbiendo) 
        //public new int GetVacaciones() //con new ya estamos viendo que estamos sobreescribiendo un metodo 
        //{
        //    Debug.WriteLine("GetVacaciones() Director");
        //    return 25;
        //}

        //public override int GetVacaciones()
        //{
        //    //el comportamiento no va a cambiar, si ejecutamos solo leerá getVacaciones de Director no de empleado
        //    int vacas = base.GetVacaciones(); //hacerlo de esta forma e opcional ya que también puedo usar le cotr
        //    Debug.WriteLine("GetVacaciones() Director");
        //    return vacas + 3;
        //}

        //es lo mismo override que new? //como funciona el metodo no cambia solo las palabras 
        public new int GetVacaciones() 
        {
            int vacas = base.GetVacaciones(); 
            Debug.WriteLine("GetVacaciones() Director");
            return vacas + 3;
        }


        //puedo tener + metods distintos de vacaciones
        //el primero es sobreescribir (override)
        //este: es una sobrecarga (overload)
        public int GetVacaciones(int diasextra)
        {
            return this.GetVacaciones() + diasextra;
        }

        //30 metodos de getVacaciones() y no sé cual está sobreescirbiendo: *
    }
}
