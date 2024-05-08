using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBrugo_Federico_Tomas
{
    public partial class pryFirma : Form
    {
        public pryFirma()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pBoxFirma.Width, pBoxFirma.Height);

            // Obtener el contexto gráfico del bitmap
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Copiar el contenido del PictureBox al bitmap
                // Captura de pantalla que se realiza al PictureBox y se carga dentro del bitmap
                g.CopyFromScreen(PointToScreen(pBoxFirma.Location), new Point(0, 0), pBoxFirma.Size);
            }

            // Mostrar un diálogo de guardar archivo
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo de imagen (*.png)|*.png|All files (*.*)|*.*";
            saveDialog.FileName = "imagen_guardada.png"; // Nombre predeterminado del archivo

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Guardar el bitmap como un archivo de imagen
                bitmap.Save(saveDialog.FileName, ImageFormat.Png);
            }

            // Liberar recursos
            bitmap.Dispose();
            try
            {
                MessageBox.Show("Firma Grabada");
                pBoxFirma.Refresh();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pBoxFirma.Image = null;
        }

        private void pBoxFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics mifirma = pBoxFirma.CreateGraphics())
                {
                    mifirma.FillEllipse(Brushes.Black, e.X, e.Y, 10, 10);


                }
            }
        }
    }
}
