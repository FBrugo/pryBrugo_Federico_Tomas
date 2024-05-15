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

        public int vida;

        public string nombreNave;
        //int damage; //daño
        public PictureBox imgNAVE;



        //constructor
        public clsNave()
        {
            //Inicializar la variable
            vida = 0;
            nombreNave = "";
        }
        //propiedades de la clase variables globales




        //Metodos (acciones)
        public void CrearJugador(string nombre)
        {
            vida = 100;
            nombreNave = nombre;
            //damage = 1;

            imgNAVE = new PictureBox();
            imgNAVE.Size = new System.Drawing.Size(35, 35);
            imgNAVE.Location = new Point(0, 600);
            imgNAVE.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNAVE.Image = Properties.Resources.Nave;
        }



        Random aleatorioEnemigo = new Random();
        Random aleatorioPosX = new Random();
        Random aleatorioPosY = new Random();
        int codigoEnemigo;
        int posX, posY;



        public void CrearEnemigo()
        {
            codigoEnemigo = aleatorioEnemigo.Next(0, 2);

            imgNAVE = new PictureBox();
            imgNAVE.Size = new System.Drawing.Size(50, 50);
            imgNAVE.SizeMode = PictureBoxSizeMode.StretchImage;

            posX = aleatorioPosX.Next(0, 550);
            posY = aleatorioPosY.Next(0, 100);
            imgNAVE.Location = new Point(posX, posY);
            imgNAVE.Tag = "naveEnemiga";

            switch (codigoEnemigo)
            {
                case 0:
                    vida = 200;
                    nombreNave = "ENEMIGO_1";
                    //damage = 2;
                    imgNAVE.Image = Properties.Resources.Enemigo_1;
                    break;
                case 1:
                    vida = 200;
                    nombreNave = "ENEMIGO_2";
                    //damage = 2;
                    imgNAVE.Image = Properties.Resources.Enemigo_2;
                    break;
            }

        }



    }
}

