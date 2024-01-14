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
            menuStrip1 = new MenuStrip();
            compraNuevaToolStripMenuItem = new ToolStripMenuItem();
            registrarNuevaCompraToolStripMenuItem = new ToolStripMenuItem();
            hisorialDeComprasToolStripMenuItem = new ToolStripMenuItem();
            visualizarElHistorialDeTransaccionesToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            visualizarElHistorialDeConsultasRealizadasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            lblTitulo.Location = new Point(259, 64);
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
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { compraNuevaToolStripMenuItem, hisorialDeComprasToolStripMenuItem, consultasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // compraNuevaToolStripMenuItem
            // 
            compraNuevaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarNuevaCompraToolStripMenuItem });
            compraNuevaToolStripMenuItem.Name = "compraNuevaToolStripMenuItem";
            compraNuevaToolStripMenuItem.Size = new Size(153, 29);
            compraNuevaToolStripMenuItem.Text = "Compra Nueva";
            // 
            // registrarNuevaCompraToolStripMenuItem
            // 
            registrarNuevaCompraToolStripMenuItem.Name = "registrarNuevaCompraToolStripMenuItem";
            registrarNuevaCompraToolStripMenuItem.Size = new Size(287, 30);
            registrarNuevaCompraToolStripMenuItem.Text = "Registrar nueva compra";
            registrarNuevaCompraToolStripMenuItem.Click += registrarNuevaCompraToolStripMenuItem_Click;
            // 
            // hisorialDeComprasToolStripMenuItem
            // 
            hisorialDeComprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarElHistorialDeTransaccionesToolStripMenuItem });
            hisorialDeComprasToolStripMenuItem.Name = "hisorialDeComprasToolStripMenuItem";
            hisorialDeComprasToolStripMenuItem.Size = new Size(196, 29);
            hisorialDeComprasToolStripMenuItem.Text = "Hisorial de Compras";
            // 
            // visualizarElHistorialDeTransaccionesToolStripMenuItem
            // 
            visualizarElHistorialDeTransaccionesToolStripMenuItem.Name = "visualizarElHistorialDeTransaccionesToolStripMenuItem";
            visualizarElHistorialDeTransaccionesToolStripMenuItem.Size = new Size(407, 30);
            visualizarElHistorialDeTransaccionesToolStripMenuItem.Text = "Visualizar el historial de transacciones";
            visualizarElHistorialDeTransaccionesToolStripMenuItem.Click += visualizarElHistorialDeTransaccionesToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarElHistorialDeConsultasRealizadasToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(107, 29);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // visualizarElHistorialDeConsultasRealizadasToolStripMenuItem
            // 
            visualizarElHistorialDeConsultasRealizadasToolStripMenuItem.Name = "visualizarElHistorialDeConsultasRealizadasToolStripMenuItem";
            visualizarElHistorialDeConsultasRealizadasToolStripMenuItem.Size = new Size(461, 30);
            visualizarElHistorialDeConsultasRealizadasToolStripMenuItem.Text = "⁮Visualizar el historial de consultas realizadas";
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
            Controls.Add(menuStrip1);
            Name = "frmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Inversiones";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem compraNuevaToolStripMenuItem;
        private ToolStripMenuItem registrarNuevaCompraToolStripMenuItem;
        private ToolStripMenuItem hisorialDeComprasToolStripMenuItem;
        private ToolStripMenuItem visualizarElHistorialDeTransaccionesToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem visualizarElHistorialDeConsultasRealizadasToolStripMenuItem;
    }
}
