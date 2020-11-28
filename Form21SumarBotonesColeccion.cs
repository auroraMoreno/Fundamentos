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
    public partial class Form21SumarBotonesColeccion : Form
    {
        
        List<Button> botones;
        Random rnd = new Random();
        public Form21SumarBotonesColeccion()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            foreach (Control control in this.Controls)
            {
                if(control is Button) {
                    this.botones.Add((Button)control);
                }
            }
            foreach(Button btn in this.botones)
            {
                btn.Text = rnd.Next(1, 50).ToString();
                btn.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int txt = int.Parse(this.txtSuma.Text);
            int btn = int.Parse(boton.Text);
            txt += btn;
            this.txtSuma.Text = txt.ToString();   
        }
    }
}
