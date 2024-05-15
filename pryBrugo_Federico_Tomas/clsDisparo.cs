using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBrugo_Federico_Tomas
{
    public class clsDisparo
    {

        // Declaración de la variable de la clase clsDisparo
        public PictureBox imgDisparo; // PictureBox para representar el disparo en la interfaz

        // Constructor de la clase clsDisparo
        public clsDisparo()
        {
            // Inicialización del PictureBox para el disparo
            imgDisparo = new PictureBox();

            // Establece el tamaño del PictureBox para el disparo como 5x5 píxeles
            imgDisparo.Size = new System.Drawing.Size(5, 5);

            // Establece el color de fondo del PictureBox como blanco
            imgDisparo.BackColor = Color.White;

            // Configura el modo de ajuste del PictureBox para que la imagen se estire y llene todo el PictureBox
            imgDisparo.SizeMode = PictureBoxSizeMode.StretchImage;

            // Asigna una etiqueta al PictureBox para identificarlo como un disparo
            imgDisparo.Tag = "Shot";
        }

        // Método para disparar (mover) el disparo a una nueva ubicación en la pantalla
        public void Disparar(Point location)
        {
            // Establece la ubicación del PictureBox del disparo en la ubicación pasada como parámetro
            imgDisparo.Location = location;
        }


    }
}
