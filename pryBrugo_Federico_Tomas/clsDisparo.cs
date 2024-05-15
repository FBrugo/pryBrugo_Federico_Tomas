using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBrugo_Federico_Tomas
{
    public class clsDisparo
    {

        public PictureBox imgDisparo;


        public clsDisparo()
        {
            imgDisparo = new PictureBox();
            imgDisparo.Size = new System.Drawing.Size(5, 5);
            imgDisparo.BackColor = Color.White;
            imgDisparo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgDisparo.Tag = "Shot";

        }
        public void Disparar(Point location)
        {
            imgDisparo.Location = location;
        }

    }
}
