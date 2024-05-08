namespace pryBrugo_Federico_Tomas
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFirma = new Button();
            btnGalaga = new Button();
            SuspendLayout();
            // 
            // btnFirma
            // 
            btnFirma.BackColor = Color.Yellow;
            btnFirma.FlatStyle = FlatStyle.Flat;
            btnFirma.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFirma.Location = new Point(78, 71);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new Size(161, 86);
            btnFirma.TabIndex = 0;
            btnFirma.Text = "FIRMAR";
            btnFirma.UseVisualStyleBackColor = false;
            btnFirma.Click += btnFirma_Click;
            // 
            // btnGalaga
            // 
            btnGalaga.BackColor = Color.Salmon;
            btnGalaga.FlatStyle = FlatStyle.Flat;
            btnGalaga.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGalaga.Location = new Point(325, 71);
            btnGalaga.Name = "btnGalaga";
            btnGalaga.Size = new Size(161, 86);
            btnGalaga.TabIndex = 1;
            btnGalaga.Text = "JUGAR";
            btnGalaga.UseVisualStyleBackColor = false;
            btnGalaga.Click += btnGalaga_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(540, 233);
            Controls.Add(btnGalaga);
            Controls.Add(btnFirma);
            Name = "Inicio";
            Text = "Presione su interes:";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFirma;
        private Button btnGalaga;
    }
}
