namespace Calculadora_Inversiones
{
    partial class frmHistorialTransacciones
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
            dgvHistorialCompras = new DataGridView();
            lblHistorialTransacciones = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCompras).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorialCompras
            // 
            dgvHistorialCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialCompras.Location = new Point(12, 68);
            dgvHistorialCompras.Name = "dgvHistorialCompras";
            dgvHistorialCompras.Size = new Size(544, 610);
            dgvHistorialCompras.TabIndex = 0;
            // 
            // lblHistorialTransacciones
            // 
            lblHistorialTransacciones.AutoSize = true;
            lblHistorialTransacciones.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorialTransacciones.Location = new Point(161, 25);
            lblHistorialTransacciones.Name = "lblHistorialTransacciones";
            lblHistorialTransacciones.Size = new Size(232, 25);
            lblHistorialTransacciones.TabIndex = 1;
            lblHistorialTransacciones.Text = "Historial de Transacciones";
            // 
            // frmHistorialTransacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(571, 690);
            Controls.Add(lblHistorialTransacciones);
            Controls.Add(dgvHistorialCompras);
            MinimumSize = new Size(587, 729);
            Name = "frmHistorialTransacciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Transacciones";
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorialCompras;
        private Label lblHistorialTransacciones;
    }
}