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
    public partial class FormConversion : Form
    {
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            //Conversion automatica 
            double mayor = 99;
            int menor = 99;
            //si igualamos mayor capacidad a menor la conversion es automatica
            mayor = menor;
            // menor = mayor; //error de compilacion

            //casting entre primitivos 
            //los primitivos están todos en minusculas 
            // (tipoAConvertir)objetoAConvertir;
            short mini = 44; //menor
            int numero = 88; //mayor 
            numero = mini; //conversion automatica;
            mini = (short)numero; //de entero a short 

            //conversion de string a tipo primitivo 
            //un string es una clase, lo sabemos porque tiene la primera letra mayuscula 
            //para poder convertir cualquier string a primitivo se usan metodos de las clases primitivas
            //se llama: parsear: 
            //tipoprimitivo.Parse(string);
            String texto = "3651";
            int num = int.Parse(texto);
            double doble = double.Parse(texto);
            //si le pongo un texto nos dará un fallo en ejecución (permite solo compilar) 
            //los fallos en ejecucion para en la linea que está dando el fallo

            //Convertir cualquier primitivo a string
            //la clase system.object contiene un metodo para convertir a string
            //.ToString();
            //cualquier obj de la clase object tiene .ToString()
            int valor = 999;
            String dato = valor.ToString();
            dato = this.ToString(); //convierte el form a toString() 
                                    //se puede convertir "cualquier" objeto a toSTring, cualqueir obj puede ser presentado a un tipo texto 

            //Los metodos pueden tener tmb sobrecarga
            MessageBox.Show("Texto", "Titulo", MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Information);
        }
    }
}
