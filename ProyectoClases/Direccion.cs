using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        #region CONSTRUCTOR

        public Direccion()
        {
            Debug.WriteLine("ctor direccion simple");
        }
        //multiples ctores con el concepto de polimorfiso
        public Direccion(String calle, String ciudad)
        {
            //inciamos las propiedades 
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Ctor con dos param");
        }

        //(11:26)!!!!!!! 
        //para hacerlo obligatorio en el form obliga a poner param 
        public Direccion(String calle, String ciudad, int cp) 
            : this(calle,ciudad) //cuando alguien le de la calle la ciudad y cp primero lee otro ctor y luego este
        {
            //this.IniciarObjetos(); //meotods intemendios 
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Ctor con dtres param");
        }

     
        #endregion
        //esta clase la voy a usar para que una persona tenga + de uan direccion: 
        //cuando no queremos comprobar valores de la propiedad se usan props autoimplementadas
        //es una propiedad que no tenemos que escribir el campo
        //está dentro el campo de la declaración 
        //ni hay if, ni _Mipropiedad, solo:
        public String Calle { get; set; }
        public String Ciudad { get; set; }
        public int CodigoPostal { get; set; }


        //cuando deseamos comproba algo usamos prop extendidas:
        //con su get, su set... (como hemos ido hacienod hasta ahora) 
        //usar una u otra depende de si quiero comproba algo o no 


    }
}
