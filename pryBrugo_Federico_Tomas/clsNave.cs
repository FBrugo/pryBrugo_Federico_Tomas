using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pryBrugo_Federico_Tomas
{
    public class clsNave
    {

        // Declaración de variables de la clase clsNave
        public int vida; // Representa la vida de la nave
        public string nombreNave; // Representa el nombre de la nave
        public PictureBox imgNAVE; // PictureBox que representa la imagen de la nave en la interfaz

        // Constructor de la clase clsNave
        public clsNave()
        {
            // Inicialización de las variables en el constructor
            vida = 0; // Inicialmente la vida se establece en 0
            nombreNave = ""; // El nombre de la nave se establece como una cadena vacía al principio
        }

        // Método para crear al jugador (nave del jugador)
        public void CrearJugador(string nombre)
        {
            // Establece la vida del jugador en 100 al crearlo
            vida = 100;

            // Asigna el nombre pasado como parámetro al nombre de la nave
            nombreNave = nombre;

            // Crea un nuevo PictureBox para la nave del jugador
            imgNAVE = new PictureBox();

            // Establece el tamaño del PictureBox para la nave del jugador
            imgNAVE.Size = new System.Drawing.Size(35, 35);

            // Establece la posición inicial de la nave del jugador en la pantalla
            imgNAVE.Location = new Point(0, 600);

            // Configura el modo de ajuste del PictureBox para que la imagen se estire y llene todo el PictureBox
            imgNAVE.SizeMode = PictureBoxSizeMode.StretchImage;

            // Asigna la imagen de la nave del jugador desde los recursos del proyecto
            imgNAVE.Image = Properties.Resources.Nave;
        }

        // Generadores de números aleatorios para ser utilizados en la generación de enemigos
        Random aleatorioEnemigo = new Random();
        Random aleatorioPosX = new Random();
        Random aleatorioPosY = new Random();

        // Variables para almacenar información sobre el enemigo que se va a crear
        int codigoEnemigo; // Código que representa el tipo de enemigo
        int posX, posY; // Posición X e Y del enemigo en la pantalla




        // Método para crear un nuevo enemigo
        public void CrearEnemigo()
        {
            // Genera un número aleatorio para determinar el tipo de enemigo (0 o 1)
            codigoEnemigo = aleatorioEnemigo.Next(0, 2);

            // Crea un nuevo PictureBox para representar al enemigo
            imgNAVE = new PictureBox();

            // Establece el tamaño del PictureBox como 50x50 píxeles
            imgNAVE.Size = new System.Drawing.Size(50, 50);

            // Configura el modo de ajuste del PictureBox para que la imagen se estire y llene todo el PictureBox
            imgNAVE.SizeMode = PictureBoxSizeMode.StretchImage;

            // Genera coordenadas aleatorias para la posición del nuevo enemigo en el eje X (horizontal)
            posX = aleatorioPosX.Next(0, 550);

            // Genera coordenadas aleatorias para la posición del nuevo enemigo en el eje Y (vertical)
            posY = aleatorioPosY.Next(0, 100);

            // Establece la posición del PictureBox en la pantalla usando las coordenadas aleatorias generadas
            imgNAVE.Location = new Point(posX, posY);

            // Asigna una etiqueta al PictureBox para identificarlo como una nave enemiga
            imgNAVE.Tag = "naveEnemiga";

            // Utiliza un switch para configurar propiedades del enemigo según el tipo generado aleatoriamente
            switch (codigoEnemigo)
            {
                // Tipo de enemigo 0
                case 0:
                    // Establece la vida del enemigo en 200
                    vida = 200;

                    // Asigna un nombre identificativo al enemigo (ENEMIGO_1)
                    nombreNave = "ENEMIGO_1";

                    // Asigna la imagen correspondiente al enemigo tipo 0
                    imgNAVE.Image = Properties.Resources.Enemigo_1;
                    break;

                // Tipo de enemigo 1
                case 1:
                    // Establece la vida del enemigo en 200
                    vida = 200;

                    // Asigna un nombre identificativo al enemigo (ENEMIGO_2)
                    nombreNave = "ENEMIGO_2";

                    // Asigna la imagen correspondiente al enemigo tipo 1
                    imgNAVE.Image = Properties.Resources.Enemigo_2;
                    break;
            }
        }




    }
}

