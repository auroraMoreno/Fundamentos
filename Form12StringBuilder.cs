using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form12StringBuilder : Form
    {
        public Form12StringBuilder()
        {
            InitializeComponent();

            //en la clase form tenemos una prop que es size con caract 
            //ancho y alto sé reconocerla, sé que hablamos de tamaño.
            //this.Size;
            //una coleccion: solo por sus caract soy capaz de reconocer que es una coleccion
            //this.Controls
            //podria ser array pero pro sus caracteristica soy capaz de decir que es un arrya
            //this.MdiChildren
            //indiependiente  a lo que sea soy capaz de diferenciarlo por uss porps

            int[] numeros = new int[3] { 14,898,33}; //Array de 3 elelemtos
            //sumar todos los num del array; 
            int suma = 0;
            //bucle foreach, a mi no e interesa numeros si no su contendio cada elemento indi de conj
            foreach (int num in numeros)
            {
                //recorer elementos del conjunto y por cada uno los sunas
                suma += num;
            }
            this.lbltiempo.Text = suma.ToString();
            //lo que haga no importa, iteresa que yo me centro en cada elelemto indiivudal. Los agrupo en un sitio y los manejo a cada uno indicidualmentoe
            //this.Controls[] //averiguar que tipo de var necesito para el each usando la ayuda 
              ///numeros[] //la ayuda me dice que son int 
            //Una vez visto uqe es controls:  cada elemetnto indiv. Podemos recorrer la coleccion: 
            foreach (Control control in this.Controls)
            {
                //al igual que arriba manej un num pa sumarlo aqui manejo la var control
                control.BackColor = Color.White; //buscamos algo uqe suene con control. por ejemplo backColor. Control es obj de form para un dibujo bc hace backColor
                                                 //Aqui si cambimaos algo pero no el obj si no un color del objeto.
                                                 //control = new Control(); esto seria cambiar un objeto
                                                 // la var que use de referencia no podemos cambiar (13:24) 
                //this.Controls.Add(new Control()); //bucle infinito 
                //bucles de ref solo recorrido, para acutar sobre obj suar otro tipo de bucle

            }
            //Se trata de ser capaz de manejar cualqueir coleccion 

        }

        private void btnreversestring_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch(); //es una clase valida que existe y se puede usar 
            //esto tiene que ver con un concept de namespace, que indica que existen librerias que son un conjunto de librerias con una serie de cat para cada uno 
            //dependiendo de la logica usaremos unas o otras: xml, acceso a datos.. OBj y clase que me van a dar una funcionalidad para una caracterisitica 
            //11:20
            //por defecto vienen det espacio de nombre: system.collections... 
            //Estos lo que permiten es poder trabjar conunas det librerias cada using que yo haga permitriá trabajr con unas librerias 
            //el suing en como un acceso directo a la libreria esto significa hacer un namespace(la carpeta) y using e lacceso direct en el escritorio 
            //SYSTEM.IO.FileInfor (usando el namespace) 
            // System.Diagnostics.Stopwatch krono; 
            //o
            //using y es directo
            //Cualqueir clase de visual studio hay que instaciarles
            krono.Start(); 

    

            //tiene cadena hola
            //recorrerá de 0 a 3 
            //cogerá el texto sobre cadena hola y coge la leta a y la pone en la posicion que sea

            //coge caja de txt y hace bucle de poscion 0 hasta la longitud de txt (ver 11:10)
            String txt = this.txtTexto.Text;
            for(int i=0;i < txt.Length; i++)
            {
                //recuperamos la ultima letra
                char letra = txt[txt.Length - 1];
                //eliminamos la ultima letra
                txt = txt.Remove(txt.Length - 1);
                //insertamos la letra en la posicion del indecide 
                txt = txt.Insert(i, letra.ToString());
            }
            this.txtTexto.Text = txt;
            krono.Stop();
            TimeSpan intervalo = krono.Elapsed;
            this.lbltiempo.Text = "Segundos " + intervalo.TotalSeconds; 
        }

        private void btnrevstrbuilder_Click(object sender, EventArgs e)
        {
            //creamos crono e iniciamos para trabajar con él 
            Stopwatch krono = new Stopwatch();
            krono.Start();

            //crear el obj stringuilder
            StringBuilder texto = new StringBuilder(); //se instacia
            //para add caracteres tiene metodo append: 
            texto.Append(this.txtTexto.Text);
            //texto = this.txttexto.TExt (esto es string no sb) 
            //mismo bucle que antes: 
            for(int i = 0; i<texto.Length; i++)
            {
                char letra = texto[texto.Length - 1]; //capturamos la ultima letra igual que antes
                //hacemos el remove con la diferencia de que esto no va a crear un nuevo obj sino que lo reaginará a un nuevo espacio de memora
                texto = texto.Remove(texto.Length - 1,1);
                texto = texto.Insert(i, letra);
                //asignamos a la caja de texto el sb
                this.txtTexto.Text = texto.ToString(); //tenemos que conversarlo ya que no es un string, solo manjea string
                krono.Stop();
                this.lbltiempo.Text = "Segundos: "
                    + krono.Elapsed.TotalSeconds;

            }

        }
    }
}
