namespace pryBrugo_Federico_Tomas
{
    partial class frmGameOver
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
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(178, 67);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(81, 20);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "lblMensaje";
            // 
            // frmGameOver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Name = "frmGameOver";
            Text = "frmGameOver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
    }
}