﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_la_vida
{
    public partial class Form1 : Form
    {
        Tablero t;
        int turno;
        public Form1()
        {
            InitializeComponent();
            t = new Tablero(10);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
