namespace Calculadora_Inversiones
{
    partial class frmCompraNueva
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
            cboUsuarios = new ComboBox();
            nupCompraNueva = new NumericUpDown();
            dtpCompra = new DateTimePicker();
            txtMontoCompraNueva = new TextBox();
            lblMontoCompra = new Label();
            lblFechaCompra = new Label();
            lblCantidad = new Label();
            lblIngreseNuevaCompra = new Label();
            btnAgregarCompra = new Button();
            btnCancelar = new Button();
            cboCedearsCompra = new ComboBox();
            lblCedearNuevaCompra = new Label();
            lblUsuarioNuevaCompra = new Label();
            ((System.ComponentModel.ISupportInitialize)nupCompraNueva).BeginInit();
            SuspendLayout();
            // 
            // cboUsuarios
            // 
            cboUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuarios.FormattingEnabled = true;
            cboUsuarios.Location = new Point(358, 205);
            cboUsuarios.Name = "cboUsuarios";
            cboUsuarios.Size = new Size(121, 23);
            cboUsuarios.TabIndex = 0;
            // 
            // nupCompraNueva
            // 
            nupCompraNueva.Location = new Point(437, 133);
            nupCompraNueva.Name = "nupCompraNueva";
            nupCompraNueva.Size = new Size(138, 23);
            nupCompraNueva.TabIndex = 4;
            // 
            // dtpCompra
            // 
            dtpCompra.Format = DateTimePickerFormat.Short;
            dtpCompra.Location = new Point(252, 133);
            dtpCompra.Name = "dtpCompra";
            dtpCompra.Size = new Size(138, 23);
            dtpCompra.TabIndex = 12;
            // 
            // txtMontoCompraNueva
            // 
            txtMontoCompraNueva.Location = new Point(81, 133);
            txtMontoCompraNueva.Name = "txtMontoCompraNueva";
            txtMontoCompraNueva.Size = new Size(138, 23);
            txtMontoCompraNueva.TabIndex = 4;
            // 
            // lblMontoCompra
            // 
            lblMontoCompra.AutoSize = true;
            lblMontoCompra.Location = new Point(92, 115);
            lblMontoCompra.Name = "lblMontoCompra";
            lblMontoCompra.Size = new Size(117, 15);
            lblMontoCompra.TabIndex = 13;
            lblMontoCompra.Text = "Monto de la Compra";
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Location = new Point(270, 115);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(100, 15);
            lblFechaCompra.TabIndex = 14;
            lblFechaCompra.Text = "Fecha de Compra";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(481, 115);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 15;
            lblCantidad.Text = "Cantidad";
            // 
            // lblIngreseNuevaCompra
            // 
            lblIngreseNuevaCompra.AutoSize = true;
            lblIngreseNuevaCompra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngreseNuevaCompra.Location = new Point(229, 43);
            lblIngreseNuevaCompra.Name = "lblIngreseNuevaCompra";
            lblIngreseNuevaCompra.Size = new Size(177, 20);
            lblIngreseNuevaCompra.TabIndex = 16;
            lblIngreseNuevaCompra.Text = "Ingrese la nueva compra";
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.Location = new Point(240, 281);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(75, 23);
            btnAgregarCompra.TabIndex = 17;
            btnAgregarCompra.Text = "Agregar Compra";
            btnAgregarCompra.UseVisualStyleBackColor = true;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(342, 281);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboCedearsCompra
            // 
            cboCedearsCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCedearsCompra.FormattingEnabled = true;
            cboCedearsCompra.Location = new Point(173, 205);
            cboCedearsCompra.Name = "cboCedearsCompra";
            cboCedearsCompra.Size = new Size(121, 23);
            cboCedearsCompra.TabIndex = 0;
            // 
            // lblCedearNuevaCompra
            // 
            lblCedearNuevaCompra.AutoSize = true;
            lblCedearNuevaCompra.Location = new Point(213, 187);
            lblCedearNuevaCompra.Name = "lblCedearNuevaCompra";
            lblCedearNuevaCompra.Size = new Size(44, 15);
            lblCedearNuevaCompra.TabIndex = 19;
            lblCedearNuevaCompra.Text = "Cedear";
            // 
            // lblUsuarioNuevaCompra
            // 
            lblUsuarioNuevaCompra.AutoSize = true;
            lblUsuarioNuevaCompra.Location = new Point(396, 187);
            lblUsuarioNuevaCompra.Name = "lblUsuarioNuevaCompra";
            lblUsuarioNuevaCompra.Size = new Size(47, 15);
            lblUsuarioNuevaCompra.TabIndex = 20;
            lblUsuarioNuevaCompra.Text = "Usuario";
            // 
            // frmCompraNueva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(665, 366);
            Controls.Add(lblUsuarioNuevaCompra);
            Controls.Add(lblCedearNuevaCompra);
            Controls.Add(cboUsuarios);
            Controls.Add(cboCedearsCompra);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarCompra);
            Controls.Add(lblIngreseNuevaCompra);
            Controls.Add(lblCantidad);
            Controls.Add(lblFechaCompra);
            Controls.Add(lblMontoCompra);
            Controls.Add(txtMontoCompraNueva);
            Controls.Add(dtpCompra);
            Controls.Add(nupCompraNueva);
            MaximumSize = new Size(681, 405);
            MinimumSize = new Size(681, 405);
            Name = "frmCompraNueva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Nueva Compra";
            ((System.ComponentModel.ISupportInitialize)nupCompraNueva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboUsuarios;
        private NumericUpDown nupCompraNueva;
        private DateTimePicker dtpCompra;
        private Label lblMontoCompra;
        private Label lblFechaCompra;
        private Label lblCantidad;
        private Label lblIngreseNuevaCompra;
        private Button btnAgregarCompra;
        private Button btnCancelar;
        public TextBox txtMontoCompraNueva;
        private ComboBox cboCedearsCompra;
        private Label lblCedearNuevaCompra;
        private Label lblUsuarioNuevaCompra;
    }
}