namespace pryBrugo_Federico_Tomas
{
    partial class InicioJuego
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnIniciar = new Button();
            txtNombreJugador = new TextBox();
            // SuspendLayout(); // Esta línea ha sido eliminada
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(668, 107);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(150, 107);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(353, 27);
            txtNombreJugador.TabIndex = 1;
            // 
            // InicioJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wp3172280;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombreJugador);
            Controls.Add(btnIniciar);
            Name = "InicioJuego";
            Text = "InicioJuego";
            // ResumeLayout(false); // Esta línea ha sido eliminada
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private TextBox txtNombreJugador;
    }
}