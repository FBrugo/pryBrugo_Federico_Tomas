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
    public partial class frmGameOver : Form
    {
        public frmGameOver(string nombreJugador)
        {
            InitializeComponent();
            lblMensaje.Text = "¡FELICIDADES  " + nombreJugador + ", GANASTE!";
        }
    }
}
