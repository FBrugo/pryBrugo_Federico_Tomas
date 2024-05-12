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
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Red;
            btnIniciar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.FromArgb(0, 0, 64);
            btnIniciar.Location = new Point(555, 126);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(196, 90);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(41, 179);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(448, 27);
            txtNombreJugador.TabIndex = 1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = SystemColors.WindowText;
            lblMensaje.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = SystemColors.ButtonHighlight;
            lblMensaje.Location = new Point(1, 114);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(514, 46);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "COLOQUE NOMBRE JUGADOR:";
            // 
            // InicioJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FONDO_JUEGO;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(txtNombreJugador);
            Controls.Add(btnIniciar);
            Name = "InicioJuego";
            Text = "InicioJuego";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private TextBox txtNombreJugador;
        private Label lblMensaje;
    }
}