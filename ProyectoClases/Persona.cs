using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
	public class Persona
	{
		//si no lleva ambito es privada (por eso ponerla publica)
		#region PROPIEDADES
		//todo los que pongamos así podemos colapsar y desplegar

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
	}
}