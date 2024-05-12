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

        // Lista para almacenar los disparos
        List<clsDisparo> listaDisparos = new List<clsDisparo>();

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

            // Ajusta la posición inicial de la nave para que aparezca más arriba en el formulario
            objNaveJugador.imgNAVE.Location = new Point((this.ClientSize.Width - objNaveJugador.imgNAVE.Width) / 2, this.ClientSize.Height - 100);
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
                if (pictureboxNave.Bounds.IntersectsWith(nave.imgNAVE.Bounds))
                {
                    return true; // Retorna verdadero si hay intersección.
                }
            }
            return false; // Retorna falso si no hay intersección.
        }

        private void timerEnemigo_Tick(object sender, EventArgs e)
        {
            if (contador < 6)
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
            // Verifica si la tecla presionada es la tecla de espacio
            if (e.KeyCode == Keys.Space)
            {
                // Activa el temporizador para los disparos
                timerShot.Enabled = true;

                // Crea una nueva instancia de la clase Disparo
                objDisparo = new clsDisparo();

                // Calcula la posición inicial del disparo, ubicándolo sobre la nave jugador
                Point location = new Point(objNaveJugador.imgNAVE.Location.X + 49,
                    objNaveJugador.imgNAVE.Location.Y - 10);

                // Realiza el disparo desde la posición calculada
                objDisparo.Disparar(location);

                // Agrega la imagen del disparo al formulario
                Controls.Add(objDisparo.imgDisparo);

                // Agrega el disparo a la lista de disparos para su posterior seguimiento
                listaDisparos.Add(objDisparo);
            }

            // Verifica si la tecla presionada es la tecla de derecha
            if (e.KeyCode == Keys.Right)
            {
                // Verifica si la posición X de la nave jugador está dentro de los límites de la pantalla
                if (objNaveJugador.imgNAVE.Location.X >= 703)
                {
                    // Si está fuera de los límites, reposiciona la nave a la izquierda de la pantalla
                    objNaveJugador.imgNAVE.Location = new Point(-20, objNaveJugador.imgNAVE.Location.Y);
                }
                else
                {
                    // Si está dentro de los límites, desplaza la nave jugador hacia la derecha
                    objNaveJugador.imgNAVE.Location = new Point(objNaveJugador.imgNAVE.Location.X + 5,
                        objNaveJugador.imgNAVE.Location.Y);
                }
            }

            // Verifica si la tecla presionada es la tecla de izquierda
            if (e.KeyCode == Keys.Left)
            {
                // Verifica si la posición X de la nave jugador está dentro de los límites de la pantalla
                if (objNaveJugador.imgNAVE.Location.X <= -18)
                {
                    // Si está fuera de los límites, reposiciona la nave a la derecha de la pantalla
                    objNaveJugador.imgNAVE.Location = new Point(831, objNaveJugador.imgNAVE.Location.Y);
                }
                else
                {
                    // Si está dentro de los límites, desplaza la nave jugador hacia la izquierda
                    objNaveJugador.imgNAVE.Location = new Point(objNaveJugador.imgNAVE.Location.X - 5,
                        objNaveJugador.imgNAVE.Location.Y);
                }
            }
        }



        private void timerShot_Tick(object sender, EventArgs e)
        {
            // Lista para almacenar los controles que se deben eliminar del formulario
            List<Control> controlesEliminar = new List<Control>();

            // Itera sobre cada disparo en la lista de disparos
            foreach (clsDisparo disparo in listaDisparos)
            {
                // Verifica si el disparo ha alcanzado la parte superior del formulario
                if (disparo.imgDisparo.Top > 0)
                {
                    // Si el disparo todavía está en pantalla, lo mueve hacia arriba
                    disparo.imgDisparo.Top -= 10; // Puedes ajustar este valor según la velocidad deseada del disparo

                    // Itera sobre todos los controles en el formulario para verificar si el disparo ha colisionado con una nave enemiga
                    foreach (Control posibleNave in this.Controls)
                    {
                        if (posibleNave.Tag == "naveEnemiga" && disparo.imgDisparo.Bounds.IntersectsWith(posibleNave.Bounds))
                        {
                            // Si hay una colisión entre el disparo y una nave enemiga, agrega ambos controles a la lista de controles a eliminar
                            controlesEliminar.Add(disparo.imgDisparo);
                            controlesEliminar.Add(posibleNave);

                            // Aumenta los puntos del jugador y actualiza el puntaje en la etiqueta correspondiente
                            puntos += 20;
                            lblPuntaje.Text = "SCORE  " + puntos.ToString();

                            // Si el jugador alcanza 100 puntos, muestra el formulario de fin de juego y cierra el juego actual
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
                    // Si el disparo está fuera de la pantalla, agrega el disparo a la lista de controles a eliminar
                    controlesEliminar.Add(disparo.imgDisparo);
                }
            }

            // Elimina los controles marcados para eliminación del formulario y los libera de la memoria
            foreach (Control control in controlesEliminar)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

    }
}
