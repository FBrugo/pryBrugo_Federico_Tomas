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
    public partial class frmFirma : Form
    {
        public frmFirma()
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

            // Obtener la carpeta de destino en el escritorio
            string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Firmas");

            // Verificar si la carpeta no existe y crearla si es necesario
            if (!Directory.Exists(carpetaDestino))
            {
                Directory.CreateDirectory(carpetaDestino);
            }

            // Construir el nombre del archivo con la fecha y hora actual
            string nombreArchivo = $"imagen_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png";

            // Construir la ruta completa del archivo
            string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

            // Guardar el bitmap como un archivo de imagen
            bitmap.Save(rutaCompleta, ImageFormat.Png);

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
