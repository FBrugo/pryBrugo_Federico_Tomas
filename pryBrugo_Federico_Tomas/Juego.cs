using System;
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
    public partial class Juego : Form
    {

        // Declaración de variables de instancia para la nave del jugador, la nave enemiga y el disparo.
        clsNave objNaveJugador = new clsNave();
        clsNave objNaveEnemigo;
        clsDisparo objDisparo;

        // Variable para almacenar los puntos del jugador.
        int puntos = 0;

        // Variable para almacenar el nombre del jugador.
        string nombre;

        // Constructor de la clase Juego que recibe el nombre del jugador como parámetro.
        public Juego(string nombreJugador)
        {
            // Inicialización de componentes del formulario.
            InitializeComponent();
            // Asignación del nombre del jugador recibido como parámetro a la variable nombre.
            nombre = nombreJugador;
        }

        // Método que se ejecuta al cargar el formulario.
        private void Juego_Load(object sender, EventArgs e)
        {
            // Creación del jugador y agregado de su imagen al formulario.
            objNaveJugador.CrearJugador(nombre);
            Controls.Add(objNaveJugador.imgNAVE);
        }

        // Contador para controlar el número de naves enemigas creadas.
        int contador = 0;
        // Lista para almacenar las naves enemigas.
        List<clsNave> DatosNavesEnemigas = new List<clsNave>();

        // Método para verificar si hay intersección entre la nave del jugador y una nave enemiga.
        private bool existeIntersepcion(PictureBox pictureboxNave)
        {
            foreach (clsNave nave in DatosNavesEnemigas)
            {
                // Comprueba si hay intersección entre los límites de la nave del jugador y la nave enemiga.
                if (pictureboxNave.Bounds.IntersectsWith(nave.imgNAVE.Bounds)) ;
                {
                    return true; // Retorna verdadero si hay intersección.
                }
            }
            return false; // Retorna falso si no hay intersección.
        }

        private void timerEnemigo_Tick(object sender, EventArgs e)
        {
            if (contador < 10)
            {
                objNaveEnemigo = new clsNave();
                objNaveEnemigo.CrearEnemigo(); // Crea un nuevo enemigo
                Controls.Add(objNaveEnemigo.imgNAVE); // Agrega el PictureBox del enemigo al formulario

                if (!existeIntersepcion(objNaveEnemigo.imgNAVE))
                {
                    
                    DatosNavesEnemigas.Add(objNaveEnemigo);
                     // Incrementa el contador

                }
                contador++;
            }
            else
            {
                timerEnemigo.Enabled = false; // Detiene el temporizador una vez que se hayan creado 10 enemigos
            }
        }

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timerShot.Enabled = true;
                objDisparo = new clsDisparo();

                Point location = new Point(objNaveJugador.imgNAVE.Location.X + 49,
                    objNaveJugador.imgNAVE.Location.Y - 10);

                objDisparo.Disparar(location);
                Controls.Add(objDisparo.imgDisparo);
            }

            if (e.KeyCode == Keys.Right)
            {
                Point location = new Point(objNaveJugador.imgNAVE.Location.X + 5,
                    objNaveJugador.imgNAVE.Location.Y);

                if (objNaveJugador.imgNAVE.Location.X >= 830)
                {
                    objNaveJugador.imgNAVE.Location = new Point(-20, objNaveJugador.imgNAVE.Location.Y);
                }

            }

            if (e.KeyCode == Keys.Left)
            {
                Point location = new Point(objNaveJugador.imgNAVE.Location.X - 5,
                    objNaveJugador.imgNAVE.Location.Y);

                if (objNaveJugador.imgNAVE.Location.X <= -18)
                {
                    objNaveJugador.imgNAVE.Location = new Point(831, objNaveJugador.imgNAVE.Location.Y);
                }

            }
        }

        private void timerShot_Tick(object sender, EventArgs e)
        {
            List<Control> controlesEliminar = new List<Control>();
            foreach (Control imagenShot in this.Controls)
            {
                if (imagenShot.Tag == "shot")
                {
                    if (imagenShot.Location.Y > 0)
                    {
                        imagenShot.Location = new Point(imagenShot.Location.X,
                            imagenShot.Location.Y );
                        foreach (Control posibleNave in this.Controls)
                        {
                            if (posibleNave.Tag == "naveEnemiga"
                                && imagenShot.Bounds.IntersectsWith(posibleNave.Bounds))
                            {
                                controlesEliminar.Add(imagenShot);
                                controlesEliminar.Add(posibleNave);
                                puntos += 20;
                                lblPuntaje.Text = puntos.ToString(); 
                                if (puntos == 100)
                                {
                                    frmGameOver frm = new frmGameOver(nombre);
                                    frm.ShowDialog();
                                    Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!controlesEliminar.Contains(imagenShot))
                        {
                            controlesEliminar.Add((imagenShot));
                        }
                    }
                }
            }
            foreach (Control control in controlesEliminar)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
