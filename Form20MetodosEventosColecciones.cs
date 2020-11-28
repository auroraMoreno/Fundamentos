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
    public partial class Form20MetodosEventosColecciones : Form
    {
        //int contador = 0; //declarar a nivel de clase //MAL //nunca se instancia aquí un objeto 
        //lista declaramos a nivel de lcase bc quiero usar la lista cuando checkee pero queiro eu este llena cuando la app arranque
        List<Button> botones;
        int contador; //solo se declaran 
        //Los obj se instancian en el ctor. Siempre:
        public Form20MetodosEventosColecciones()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //podemos quitar estas lineas bc lo estamos haciendo abajo en el foreach
            //this.botones.Add(this.button1);
            //this.botones.Add(this.button2);
            //this.botones.Add(this.button3);
            //Como hablamos de colecciones en forms tenemos una coleccion que es controls dentro de forms
            //this.controls.
            //Si quremos guardar todos los botnes del form podemos recorrer la coleccion this.control
            //y almacenar solo lso botones en la coleccion 
            foreach(Control control in this.Controls)
            {
                //da igual el chek las cajas lo que tenga,
                //me interesan los buttons: 
                //esto son todos los botones si quiero algunso pues lo haria de otra forma (11:55)
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }
        }

        //No tiene nada que ver un emtodo de evento (cuando) con un metodo propio de la clase 
        //estos los creamos como e¡herramienta 11:38 (ahorarse codigo repetiivo

        void AddEvents(bool activar)
        {
            foreach (Button boton in botones)
            {
                if(activar == true) {
                    boton.Click += MostrarMensaje;
                }
                else
                {
                    boton.Click -= MostrarMensaje;
                }
            //11:40!!!!!! MUY IMPORTATNTE 
             
            }
        }

        private void chkAsociarMetodos_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chkAsociarMetodos.Checked == true)
            {
                this.contador += 1;
                //this.button1.Click += MostrarMensaje; //tiene acumulacion de eventos 
                //ahora queremos recorrer todos lso botones:
                //foreach(Button boton in botones)
                //{
                //    //decirle que cada boton:
                //    boton.Click += MostrarMensaje;
                //}
                this.AddEvents(true);
            }
            else //añadiendo esto no podemos tener más de 1 evento 
            {
                //quitamos la asociacion del evento
                this.contador -= 1;
                //this.button1.Click -= MostrarMensaje;
                //lo mismo que en el if pero quitandolo
                //foreach (Button boton in botones)
                //{
                //    boton.Click -= MostrarMensaje;
                //}
                this.AddEvents(false);
            } //asñi con el foreach culaquier boton ya realiza el mensjae 
            
            this.lblnumeventos.Text = "Eventos " + this.contador; //numero de veces que veremos el pop up 
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            //MessageBox.Show("Pulsado");
            //VIenen varios obj.. Está leyendo 3 controles 
            //como diferenciamos el obj que realiza la llamada a l metodo?
            //el obj que realiza la llamada al metodo 
            //11:47! 
            //sender viene como un object pero qué es enrealidad? 
            //cuando hago click sender es un button 
            Button boton = (Button)sender;
            boton.BackColor = Color.LightCoral;
            //he capturado dentro de sender cada elemento individual que necesitamos
        }
    }
}
