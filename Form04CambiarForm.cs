﻿using System;
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
    public partial class Form04CambiarForm : Form
    {
        public Form04CambiarForm()
        {
            InitializeComponent();
        }

        private void btnposicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtposicionx.Text);
            int y = int.Parse(this.txtposiciony.Text);
            this.btnposicion.Location = new Point(x, y);
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtrojo.Text);
            int verde = int.Parse(this.txtverde.Text);
            int azul = int.Parse(this.txtazul.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
