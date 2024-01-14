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
            gbxCedear = new GroupBox();
            cboCedearsCompra = new ComboBox();
            rdbCedearNuevo = new RadioButton();
            txtCedearNuevo = new TextBox();
            gbxUsuario = new GroupBox();
            cboUsuarios = new ComboBox();
            rdbUsuarioNuevo = new RadioButton();
            txtusuarioNuevo = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            lblMontoCompra = new Label();
            lblFechaCompra = new Label();
            lblCantidad = new Label();
            lblIngreseNuevaCompra = new Label();
            btnAgregarCompra = new Button();
            btnCancelar = new Button();
            gbxCedear.SuspendLayout();
            gbxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // gbxCedear
            // 
            gbxCedear.Controls.Add(cboCedearsCompra);
            gbxCedear.Controls.Add(rdbCedearNuevo);
            gbxCedear.Controls.Add(txtCedearNuevo);
            gbxCedear.Location = new Point(154, 166);
            gbxCedear.Name = "gbxCedear";
            gbxCedear.Size = new Size(158, 192);
            gbxCedear.TabIndex = 11;
            gbxCedear.TabStop = false;
            gbxCedear.Text = "Cedear";
            // 
            // cboCedearsCompra
            // 
            cboCedearsCompra.FormattingEnabled = true;
            cboCedearsCompra.Location = new Point(17, 34);
            cboCedearsCompra.Name = "cboCedearsCompra";
            cboCedearsCompra.Size = new Size(121, 23);
            cboCedearsCompra.TabIndex = 0;
            // 
            // rdbCedearNuevo
            // 
            rdbCedearNuevo.AutoSize = true;
            rdbCedearNuevo.Location = new Point(28, 98);
            rdbCedearNuevo.Name = "rdbCedearNuevo";
            rdbCedearNuevo.Size = new Size(100, 19);
            rdbCedearNuevo.TabIndex = 1;
            rdbCedearNuevo.TabStop = true;
            rdbCedearNuevo.Text = "Cedear Nuevo";
            rdbCedearNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCedearNuevo
            // 
            txtCedearNuevo.Location = new Point(28, 123);
            txtCedearNuevo.Name = "txtCedearNuevo";
            txtCedearNuevo.Size = new Size(100, 23);
            txtCedearNuevo.TabIndex = 3;
            // 
            // gbxUsuario
            // 
            gbxUsuario.Controls.Add(cboUsuarios);
            gbxUsuario.Controls.Add(rdbUsuarioNuevo);
            gbxUsuario.Controls.Add(txtusuarioNuevo);
            gbxUsuario.Location = new Point(323, 166);
            gbxUsuario.Name = "gbxUsuario";
            gbxUsuario.Size = new Size(158, 192);
            gbxUsuario.TabIndex = 11;
            gbxUsuario.TabStop = false;
            gbxUsuario.Text = "Usuario";
            // 
            // cboUsuarios
            // 
            cboUsuarios.FormattingEnabled = true;
            cboUsuarios.Location = new Point(24, 38);
            cboUsuarios.Name = "cboUsuarios";
            cboUsuarios.Size = new Size(121, 23);
            cboUsuarios.TabIndex = 0;
            // 
            // rdbUsuarioNuevo
            // 
            rdbUsuarioNuevo.AutoSize = true;
            rdbUsuarioNuevo.Location = new Point(30, 89);
            rdbUsuarioNuevo.Name = "rdbUsuarioNuevo";
            rdbUsuarioNuevo.Size = new Size(103, 19);
            rdbUsuarioNuevo.TabIndex = 1;
            rdbUsuarioNuevo.TabStop = true;
            rdbUsuarioNuevo.Text = "Usuario Nuevo";
            rdbUsuarioNuevo.UseVisualStyleBackColor = true;
            // 
            // txtusuarioNuevo
            // 
            txtusuarioNuevo.Location = new Point(33, 114);
            txtusuarioNuevo.Name = "txtusuarioNuevo";
            txtusuarioNuevo.Size = new Size(100, 23);
            txtusuarioNuevo.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(438, 109);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(117, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(257, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(117, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 4;
            // 
            // lblMontoCompra
            // 
            lblMontoCompra.AutoSize = true;
            lblMontoCompra.Location = new Point(75, 78);
            lblMontoCompra.Name = "lblMontoCompra";
            lblMontoCompra.Size = new Size(117, 15);
            lblMontoCompra.TabIndex = 13;
            lblMontoCompra.Text = "Monto de la Compra";
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Location = new Point(257, 78);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(100, 15);
            lblFechaCompra.TabIndex = 14;
            lblFechaCompra.Text = "Fecha de Compra";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(471, 78);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 15;
            lblCantidad.Text = "Cantidad";
            // 
            // lblIngreseNuevaCompra
            // 
            lblIngreseNuevaCompra.AutoSize = true;
            lblIngreseNuevaCompra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngreseNuevaCompra.Location = new Point(222, 38);
            lblIngreseNuevaCompra.Name = "lblIngreseNuevaCompra";
            lblIngreseNuevaCompra.Size = new Size(177, 20);
            lblIngreseNuevaCompra.TabIndex = 16;
            lblIngreseNuevaCompra.Text = "Ingrese la nueva compra";
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.Location = new Point(217, 405);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(75, 23);
            btnAgregarCompra.TabIndex = 17;
            btnAgregarCompra.Text = "Agregar Compra";
            btnAgregarCompra.UseVisualStyleBackColor = true;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(356, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCompraNueva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 466);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarCompra);
            Controls.Add(lblIngreseNuevaCompra);
            Controls.Add(lblCantidad);
            Controls.Add(lblFechaCompra);
            Controls.Add(lblMontoCompra);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(gbxCedear);
            Controls.Add(gbxUsuario);
            Name = "frmCompraNueva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Nueva Compra";
            gbxCedear.ResumeLayout(false);
            gbxCedear.PerformLayout();
            gbxUsuario.ResumeLayout(false);
            gbxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxCedear;
        private ComboBox cboCedearsCompra;
        private RadioButton rdbCedearNuevo;
        private TextBox txtCedearNuevo;
        private GroupBox gbxUsuario;
        private ComboBox cboUsuarios;
        private RadioButton rdbUsuarioNuevo;
        private TextBox txtusuarioNuevo;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label lblMontoCompra;
        private Label lblFechaCompra;
        private Label lblCantidad;
        private Label lblIngreseNuevaCompra;
        private Button btnAgregarCompra;
        private Button btnCancelar;
        public TextBox textBox1;
    }
}