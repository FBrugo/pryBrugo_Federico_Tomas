﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBrugo_Federico_Tomas
{
    public partial class InicioJuego : Form
    {
        public string NombreJugador { get; set; }
        public InicioJuego()
        {
            InitializeComponent();
        }
       

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Juego formulariojuego = new Juego(NombreJugador);
            formulariojuego.Show();
        }
    }
}
