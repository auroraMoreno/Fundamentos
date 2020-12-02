using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    #region ENUMERACIONES
	//(9:28)
	public enum TipoGenero
    {
		Maculino = 0,
		Femenino=1
    }

	public enum Paises
    {
		//si no le ponemos valores los autoasgina por si mismo 
		España =0, Inglaterra = 1, Francia = 2, Argentina = 3
    }

    #endregion
    public class Persona
	{

        #region CONSTRUCTORES

        public Persona()
        {
			Debug.WriteLine("Contrustor persona");
        }

        public Persona(int edad, String nombre, String ape)
        {
			Debug.WriteLine("ctor con cosas");
        }

        //ctor par recibir 2 datos:
        public Persona(String nombre, String apellidos)
        {
			Debug.WriteLine("ctor persona con param");
			this.Nombre = nombre;
			this.Apellidos = apellidos;
        }

        #endregion

        //si no lleva ambito es privada (por eso ponerla publica)
        #region PROPIEDADES
        //todo los que pongamos así podemos colapsar y desplegar

        //va a hacer 2 propiedad: una extendida con la direccion de casa 
        private Direccion _Domicilio;
        public Direccion Domicilio {
            get { return this._Domicilio; }
			set { this._Domicilio = value; } }

        public Direccion DomicilioVacaciones { get; set; }

        //propiedades para esas enumeraciones
        private TipoGenero _Genero;

		public TipoGenero Genero
        {
            get { return this._Genero; }
            set { 
				//Debemos controlar los valores de las enum para ver si coinciden 
				//con nuestras opciones
				if(value !=TipoGenero.Femenino && value != TipoGenero.Maculino)
                {
					throw new Exception("Rango de generos no soportado");
                }
				this._Genero = value; }
        }

		private Paises _Nacionalidad;

		public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set { this._Nacionalidad = value; }
        }

		//Una propiedad indizada contiene multiples elementos 
		//Si yo pongo el 0 contiene la primera posicion, si pongo en texto 0 contiene la priemra letra "t"
		//Como conjuntos, neceistmaos un campo (sea indizada o no ) para manejra la propiedad
		//Ese campo debe ser un conjunto dependiendo lo que queramos
		//QUiero crear una propiedad que contenga espacio para 5 descripcciones de la persona
		//si pone 0 ponga rubia, si pone 2...
		//Mi idea es: 
		//Person[0] = "Ojos Verdes" //y cuadno lo recupero que me deuvlva eso 
		//"ojos verdes" es un strng, si yo quiero 5 strings estaticos necesito un array 
		//si no fuera estático pondria una coleccion
		//crear propiedad que permita alamcenar 5 descriciones:
		private String[] _Descripciones = new String[5];
        //Un campo indizada no tiene name 
        //se utiliza la palabra this. para crearla 
        //de qué tipo va a ser la propiedad? //string bc auqnue ponga perosn[0] devovlera un unico string 
        //hasta hora tenia propiedad y _propiedad 
        //la propiedad es multiple pero devovlerá uno de esos 5
        //cuando accedo a numeros[0] (9:59) se va al form 26 
        //por eso se pone que devuelve string bc eso va a devovler
        public String this[int indice] { //(10:02)
            get { return this._Descripciones[indice]; }
			set { this._Descripciones[indice] = value; } }





        //Campos de la clase
        //un campo suele ser privado y herramienta para la clase (es una varable) 
        //Modificadores de acceso, tiene que ver con la encapsulación (solo dejaré ver lo que yo quiero que se vea)
        //13:43
        //public String Nombre;
        //public int Edad;

        //En VS no se crean campos accesibles, siempre se crear propuedades
        //una propiedad es un campo pero contiene un ´códhgo donde nos permite controlar elementos de codig
        //Sintaxis de propiedad: 
        //siempre public (si quiero dejar el acceso) 
        //ver caputra de onenote paco 
        //14:00
        //las propiedades siempre tendrán un campo de control 
        //el campo será privado para la clase y será el encargado de manejar la propiedad
        //so quiero asigno el campo, si no, no
        //los campos de propiedad se representan con _PropertyName 
        private String _Nombre; //la propuedad en luegar de devolverse a si misma devlverá el campo
								//en lugar de devolver la propiedad está el campo 


		public String Nombre
		{
			get
			{
				//devolvemos un valor del tipo 
				return this._Nombre;
			}
			set
			{
				//establecemos un valor, con value visualizamos esto
				this._Nombre = value;
			}
		}

        private String _Apellidos { get; set; }
        public String Apellidos
		{
			get { return this._Apellidos; }

			set { this._Apellidos = value; }
		}
        //Campo de la propiedad 
        private int _Edad;
		public int Edad
		{
			get
			{
				return this._Edad;
			}
			set
			{
				//códgio para controlar los valores asginados a la propiedad 
				if (value < 0)
				{
					//damos edad por defecto 
					//no le damos ningun toque
					//para lanzar excepciones se realiza con TipoException

					throw new Exception("Edad negativa: " + value);
				}
				else
				{
					this._Edad = value;
				}
				this._Edad = value;
			}
		}

        #endregion

        #region METODOS
		
		//METODOS void y METODOS return 
		//Podemos tener metodos con param opcionales 
		//public void MEtodoParamOpcional(int num, int paramOpcional){} ahora mismo 
		//es obligatorio y hay que pasarlo un param 
		//person.Metodo(55,parametoropcional:66) //asi se pone en caso de que haya más de un para opciona

		//SOBRECARGA DE UN METODO
		//un metodo tiene diferentes formas 
		//nadie teien 3 pedales de freno en el coche, hay 1 y dependiendo de como se pise se comporta de una forma u otr
		//cuando un metodo tiene distintas formas tiene distintos codigos
		//el metodo debe llamarse igual y tener disitntos param y tipos para poder hacer sobrecarga
		//esto tiene que ver con el c. de polimorfismo
		//metodo que get nombre completo
		public String GetNombreCompleto() //forma de un metodo es el nombre y el tipo el String
        {
			return this.Nombre + " " + this.Apellidos; //en la clase da igual usar el campo o la propiedad

        }

		//podemos tener multiples metodos da igual stirng que void y poedmos enviar l oque sea 
		public String GetNombreCompleto(bool ordenacion) {
			//10:36
			if(ordenacion == true)
            {
				return this.Apellidos + ", " + this.Nombre;
            }
            else
            {
				return this.GetNombreCompleto(); //llama al que no tiene param 
            }
		}
		//lo que importa es la forma de un metodo:
		public void GetNombreCompleto(int valor) //tiene que recibir parametros ya que ya tengo uno que no recibe
        {} //(10:40)

		public String GetNombreCompleto(int valor, int otro)
        {
			return this.GetNombreCompleto().ToUpper();
        }

        #endregion
    }
}