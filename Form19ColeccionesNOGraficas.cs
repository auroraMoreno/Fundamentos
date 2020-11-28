using System;
using System.Collections;
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
    public partial class Form19ColeccionesNOGraficas : Form
    {
        public Form19ColeccionesNOGraficas()
        {
            InitializeComponent();

            //this.button2.Click += RealizarClick; //tab y luego cambiar nombre a uno + aporpiad


            //creamos coleccion de objectos arryList: 
            //no olvidar hacer el using system.collecitons
            //ArrayList coleccion = new ArrayList();
            ////add a la coleccion:
            //coleccion.Add(this.button1);
            //coleccion.Add(this.button2);
            //coleccion.Add(this.button3);
            //coleccion.Add(this.textBox1); //guardo un txtbox cuando ejecute todo compila pero hasta que no lelgo al fallo no me entero 
            //cambiar el color de fondo de un btn, viene su clase abtracta y no viene ni lso metodos de btn ni prop
            //hacer casting a la clase definida
            //((Button)coleccion[0]).BackColor = Color.AliceBlue;
            ////puedo equivocarme al hacer el casting 
            ////+posibilidad a errores 

            ////un bucle each permite la conversion de obj a clase definida: 
            ////hace la ocnversion por mí (implicita) 
            ////foreach(Button btn in coleccion) //tenemos todos los botones en la coleccion
            ////{
            ////    //entonces btn ya esta definido: 
            ////    btn.BackColor = Color.Green;
            ////}
            //////las colecciones pueden venir de capa en capa y hasta que no me lelgue a la capa final no me entero del error
            ////para que no de error nos abstraemos: 
            //foreach(Control btn in coleccion)
            //{
            //    btn.BackColor = Color.Blue;
            //}

            //COLECCIONES GENERICAS: 
            //son + eficientes, tiene tipado y + facil detectar errores en compilacion (m¡esta es la mayor ventaja)
            //no permitirá escirbir si yo no hago las cosas bien
            //List<Button> btns = new List<Button>();
            //btns.Add(this.button1);
            //btns.Add(this.button2);
            //btns.Add(this.button3);
            //el compilador detecta errores de progrmaacion 
            //btns.Add(this.textBox1); //detecta que esto es erroneo y no deja compilar 
            //otra ventaja: los obj ya vienen tipados no hay que hacer castin yaque ya vienen en un forma definida
            //btns[0].BackColor = Color.Red; //Acceso a sus propiedades y característcas

            // cambiar esto a controls: (10:54)
            List<Control> btns = new List<Control>();
            btns.Add(this.button1);
            btns.Add(this.button2);
            btns.Add(this.button3);
            btns.Add(this.textBox1);
            //reocrrer todos lso obj de la coleccion:
            foreach (Control control in btns)
            {
                control.BackColor = Color.AliceBlue;
                //para reazliar algo SOLO con los txt 
                //poner txtbox en otro color 
                //para pregunrar si un obj es de una clase determinaa (ahora viene como control) se usa el operador:
                //is
                //si el objeto que sea is Clase:
                //if (Object is CLase) { }
                if(control is TextBox)
                {
                    control.BackColor = Color.Red;
                    //La clase txtbox tiene un metodo que es .Paste(); 
                    //pega del portapapeles en la caja 
                    //control.Paste(); //no lo coge (el compilador no sbae que es un txt ya que el obj viene en la calse controls)
                    //la clase control no tiene paste por lo que habría que hacer uncasting
                    //el backcolor si lo permito bc todos los controles tiene bacColor pero no tdos loctrl tienen paste por loque hay que hacer un casting 
                    //par a poder acceder al metodo
                    ((TextBox)control).Paste(); //baja a la clas eespcifica que ya que uqiere un metodo especifico de la Tetbox 

                }
             
            }

        }

        //private void RealizarClick(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
