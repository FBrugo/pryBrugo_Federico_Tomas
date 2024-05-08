namespace pryBrugo_Federico_Tomas
{
    partial class pryFirma
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
            btnBorrar = new Button();
            btnGuardar = new Button();
            pBoxFirma = new PictureBox();
            lbl1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxFirma).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.LightPink;
            btnBorrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(12, 314);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(109, 56);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Pink;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(550, 314);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 56);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pBoxFirma
            // 
            pBoxFirma.BackColor = Color.White;
            pBoxFirma.Location = new Point(12, 123);
            pBoxFirma.Name = "pBoxFirma";
            pBoxFirma.Size = new Size(647, 174);
            pBoxFirma.TabIndex = 2;
            pBoxFirma.TabStop = false;
            pBoxFirma.MouseMove += pBoxFirma_MouseMove;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(-1, 21);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(680, 64);
            lbl1.TabIndex = 3;
            lbl1.Text = "Dibuje su firma en el recuadro blanco presionando \r\nclick derecho del mouse :";
            // 
            // pryFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(671, 394);
            Controls.Add(lbl1);
            Controls.Add(pBoxFirma);
            Controls.Add(btnGuardar);
            Controls.Add(btnBorrar);
            Name = "pryFirma";
            Text = "pryFirma";
            ((System.ComponentModel.ISupportInitialize)pBoxFirma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Button btnGuardar;
        private PictureBox pBoxFirma;
        private Label lbl1;
    }
}