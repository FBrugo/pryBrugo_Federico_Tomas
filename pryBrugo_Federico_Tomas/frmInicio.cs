namespace pryBrugo_Federico_Tomas
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            frmFirma pryFirma = new frmFirma();
            pryFirma.Show();
        }

        private void btnGalaga_Click(object sender, EventArgs e)
        {
            frmInicioJuego inicioJuego = new frmInicioJuego();
            inicioJuego.Show();
        }
    }
}
