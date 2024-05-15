namespace pryBrugo_Federico_Tomas
{
    partial class frmJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timerEnemigo = new System.Windows.Forms.Timer(components);
            timerShot = new System.Windows.Forms.Timer(components);
            lblPuntaje = new Label();
            SuspendLayout();
            // 
            // timerEnemigo
            // 
            timerEnemigo.Enabled = true;
            timerEnemigo.Interval = 500;
            timerEnemigo.Tag = "naveEnemiga";
            timerEnemigo.Tick += timerEnemigo_Tick;
            // 
            // timerShot
            // 
            timerShot.Enabled = true;
            timerShot.Tag = "shot";
            timerShot.Tick += timerShot_Tick;
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntaje.ForeColor = Color.Red;
            lblPuntaje.Location = new Point(446, 9);
            lblPuntaje.Margin = new Padding(6, 0, 6, 0);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(130, 31);
            lblPuntaje.TabIndex = 0;
            lblPuntaje.Text = "SCORE 000";
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(582, 403);
            Controls.Add(lblPuntaje);
            Name = "Juego";
            Text = "Juego";
            Load += Juego_Load;
            KeyDown += Juego_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerEnemigo;
        private System.Windows.Forms.Timer timerShot;
        private Label lblPuntaje;
    }
}