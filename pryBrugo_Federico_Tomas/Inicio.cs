namespace pryBrugo_Federico_Tomas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            pryFirma pryFirma = new pryFirma();
            pryFirma.Show();
        }

        private void btnGalaga_Click(object sender, EventArgs e)
        {
            InicioJuego inicioJuego = new InicioJuego();
            inicioJuego.Show();
        }
    }
}
