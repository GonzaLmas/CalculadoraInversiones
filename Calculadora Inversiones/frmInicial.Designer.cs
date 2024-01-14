namespace Calculadora_Inversiones
{
    partial class frmInicial
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
            cboCedears = new ComboBox();
            txtMontoCompra = new TextBox();
            txtPorcentajeCompra = new TextBox();
            txtMontoGanancia = new TextBox();
            txtPorcentajeGanancia = new TextBox();
            lblTitulo = new Label();
            lblCedear = new Label();
            lblMontoCompra = new Label();
            lblPorcentajeCompra = new Label();
            lblMontoGanancia = new Label();
            lblPorcentajeGanancia = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // cboCedears
            // 
            cboCedears.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCedears.FormattingEnabled = true;
            cboCedears.Location = new Point(307, 125);
            cboCedears.Name = "cboCedears";
            cboCedears.Size = new Size(146, 23);
            cboCedears.TabIndex = 0;
            // 
            // txtMontoCompra
            // 
            txtMontoCompra.Location = new Point(226, 208);
            txtMontoCompra.Name = "txtMontoCompra";
            txtMontoCompra.Size = new Size(136, 23);
            txtMontoCompra.TabIndex = 1;
            txtMontoCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPorcentajeCompra
            // 
            txtPorcentajeCompra.Location = new Point(399, 208);
            txtPorcentajeCompra.Name = "txtPorcentajeCompra";
            txtPorcentajeCompra.ReadOnly = true;
            txtPorcentajeCompra.Size = new Size(136, 23);
            txtPorcentajeCompra.TabIndex = 5;
            txtPorcentajeCompra.TabStop = false;
            txtPorcentajeCompra.Text = "100%";
            txtPorcentajeCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMontoGanancia
            // 
            txtMontoGanancia.Location = new Point(226, 282);
            txtMontoGanancia.Name = "txtMontoGanancia";
            txtMontoGanancia.Size = new Size(136, 23);
            txtMontoGanancia.TabIndex = 2;
            txtMontoGanancia.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPorcentajeGanancia
            // 
            txtPorcentajeGanancia.Location = new Point(399, 282);
            txtPorcentajeGanancia.Name = "txtPorcentajeGanancia";
            txtPorcentajeGanancia.ReadOnly = true;
            txtPorcentajeGanancia.Size = new Size(136, 23);
            txtPorcentajeGanancia.TabIndex = 4;
            txtPorcentajeGanancia.TabStop = false;
            txtPorcentajeGanancia.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(262, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(241, 25);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Calculadora de Inversiones";
            // 
            // lblCedear
            // 
            lblCedear.AutoSize = true;
            lblCedear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCedear.Location = new Point(354, 105);
            lblCedear.Name = "lblCedear";
            lblCedear.Size = new Size(50, 17);
            lblCedear.TabIndex = 6;
            lblCedear.Text = "Cedear";
            // 
            // lblMontoCompra
            // 
            lblMontoCompra.AutoSize = true;
            lblMontoCompra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoCompra.Location = new Point(246, 188);
            lblMontoCompra.Name = "lblMontoCompra";
            lblMontoCompra.Size = new Size(101, 17);
            lblMontoCompra.TabIndex = 7;
            lblMontoCompra.Text = "Monto Compra";
            // 
            // lblPorcentajeCompra
            // 
            lblPorcentajeCompra.AutoSize = true;
            lblPorcentajeCompra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajeCompra.Location = new Point(428, 188);
            lblPorcentajeCompra.Name = "lblPorcentajeCompra";
            lblPorcentajeCompra.Size = new Size(72, 17);
            lblPorcentajeCompra.TabIndex = 4;
            lblPorcentajeCompra.Text = "Porcentaje";
            // 
            // lblMontoGanancia
            // 
            lblMontoGanancia.AutoSize = true;
            lblMontoGanancia.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoGanancia.Location = new Point(239, 262);
            lblMontoGanancia.Name = "lblMontoGanancia";
            lblMontoGanancia.Size = new Size(108, 17);
            lblMontoGanancia.TabIndex = 9;
            lblMontoGanancia.Text = "Monto Ganancia";
            // 
            // lblPorcentajeGanancia
            // 
            lblPorcentajeGanancia.AutoSize = true;
            lblPorcentajeGanancia.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajeGanancia.Location = new Point(399, 262);
            lblPorcentajeGanancia.Name = "lblPorcentajeGanancia";
            lblPorcentajeGanancia.Size = new Size(131, 17);
            lblPorcentajeGanancia.TabIndex = 10;
            lblPorcentajeGanancia.Text = "Porcentaje Ganancia";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(340, 336);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblPorcentajeGanancia);
            Controls.Add(lblMontoGanancia);
            Controls.Add(lblPorcentajeCompra);
            Controls.Add(lblMontoCompra);
            Controls.Add(lblCedear);
            Controls.Add(lblTitulo);
            Controls.Add(txtPorcentajeGanancia);
            Controls.Add(txtMontoGanancia);
            Controls.Add(txtPorcentajeCompra);
            Controls.Add(txtMontoCompra);
            Controls.Add(cboCedears);
            Name = "frmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Inversiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMontoCompra;
        private TextBox txtPorcentajeCompra;
        private TextBox txtMontoGanancia;
        private TextBox txtPorcentajeGanancia;
        private Label lblTitulo;
        private Label lblCedear;
        private Label lblMontoCompra;
        private Label lblPorcentajeCompra;
        private Label lblMontoGanancia;
        private Label lblPorcentajeGanancia;
        private Button btnCalcular;
        public ComboBox cboCedears;
    }
}
