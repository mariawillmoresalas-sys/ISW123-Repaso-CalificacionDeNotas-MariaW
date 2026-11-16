namespace ISW123_Repaso_CalificacionDeNotas_MariaW
{
    partial class Form1
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
            nudNotas = new NumericUpDown();
            lblNotas = new Label();
            btnCalificar = new Button();
            lblLetras = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNotas).BeginInit();
            SuspendLayout();
            // 
            // nudNotas
            // 
            nudNotas.Location = new Point(162, 76);
            nudNotas.Name = "nudNotas";
            nudNotas.Size = new Size(120, 23);
            nudNotas.TabIndex = 0;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Location = new Point(102, 78);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(38, 15);
            lblNotas.TabIndex = 1;
            lblNotas.Text = "Notas";
            // 
            // btnCalificar
            // 
            btnCalificar.Location = new Point(311, 78);
            btnCalificar.Name = "btnCalificar";
            btnCalificar.Size = new Size(75, 23);
            btnCalificar.TabIndex = 2;
            btnCalificar.Text = "Calificar";
            btnCalificar.UseVisualStyleBackColor = true;
            btnCalificar.Click += btnCalificar_Click;
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLetras.ForeColor = SystemColors.MenuHighlight;
            lblLetras.Location = new Point(72, 156);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(68, 30);
            lblLetras.TabIndex = 3;
            lblLetras.Text = "85→B";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 213);
            Controls.Add(lblLetras);
            Controls.Add(btnCalificar);
            Controls.Add(lblNotas);
            Controls.Add(nudNotas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudNotas;
        private Label lblNotas;
        private Button btnCalificar;
        private Label lblLetras;
    }
}
