namespace Ventas_Milton.Vista
{
    partial class frmVentas
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTipoTransaccion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.lvTercerosPorDNI = new System.Windows.Forms.ListView();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblIgv = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblEnLetras = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtTercero = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnTerceros = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            this.idMercaderia_existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExistencia_existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_mercaderia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdcutos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mercaderia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdcutos)).BeginInit();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(930, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(16, 17);
            this.lblEstado.Text = "...";
            // 
            // lblTipoTransaccion
            // 
            this.lblTipoTransaccion.AutoSize = true;
            this.lblTipoTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTransaccion.Location = new System.Drawing.Point(19, 6);
            this.lblTipoTransaccion.Name = "lblTipoTransaccion";
            this.lblTipoTransaccion.Size = new System.Drawing.Size(163, 25);
            this.lblTipoTransaccion.TabIndex = 6;
            this.lblTipoTransaccion.Text = "TRANSACCION";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(62, 104);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(168, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Location = new System.Drawing.Point(62, 80);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(168, 20);
            this.txtSerie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serie:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(13, 52);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(217, 21);
            this.cboTipoDocumento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento:";
            // 
            // pnlProducto
            // 
            this.pnlProducto.BackColor = System.Drawing.Color.LightBlue;
            this.pnlProducto.Controls.Add(this.label13);
            this.pnlProducto.Controls.Add(this.label12);
            this.pnlProducto.Controls.Add(this.txtCantidad);
            this.pnlProducto.Controls.Add(this.txtPrecio);
            this.pnlProducto.Controls.Add(this.label11);
            this.pnlProducto.Controls.Add(this.txtProducto);
            this.pnlProducto.Controls.Add(this.label10);
            this.pnlProducto.Controls.Add(this.txtCodBarras);
            this.pnlProducto.Location = new System.Drawing.Point(6, 173);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(920, 56);
            this.pnlProducto.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(741, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(739, 27);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(101, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(614, 27);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(101, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nombre Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(171, 27);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(424, 20);
            this.txtProducto.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Codigo de Barras";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodBarras.Location = new System.Drawing.Point(11, 27);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(152, 20);
            this.txtCodBarras.TabIndex = 0;
            this.txtCodBarras.TextChanged += new System.EventHandler(this.txtCodBarras_TextChanged);
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lvClientes);
            this.panel4.Controls.Add(this.lvProductos);
            this.panel4.Controls.Add(this.lvTercerosPorDNI);
            this.panel4.Controls.Add(this.pnlTotal);
            this.panel4.Controls.Add(this.pnlPrincipal);
            this.panel4.Controls.Add(this.pnlProductos);
            this.panel4.Controls.Add(this.pnlProducto);
            this.panel4.Controls.Add(this.pnlBotones);
            this.panel4.Controls.Add(this.statusStrip1);
            this.panel4.Location = new System.Drawing.Point(6, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 570);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lvClientes
            // 
            this.lvClientes.FullRowSelect = true;
            this.lvClientes.GridLines = true;
            this.lvClientes.Location = new System.Drawing.Point(334, 87);
            this.lvClientes.MultiSelect = false;
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(489, 16);
            this.lvClientes.TabIndex = 17;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            this.lvClientes.Visible = false;
            this.lvClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvClientes_KeyPress);
            // 
            // lvProductos
            // 
            this.lvProductos.FullRowSelect = true;
            this.lvProductos.GridLines = true;
            this.lvProductos.Location = new System.Drawing.Point(17, 221);
            this.lvProductos.MultiSelect = false;
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(829, 12);
            this.lvProductos.TabIndex = 16;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            this.lvProductos.Visible = false;
            this.lvProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvProductos_KeyPress);
            // 
            // lvTercerosPorDNI
            // 
            this.lvTercerosPorDNI.FullRowSelect = true;
            this.lvTercerosPorDNI.GridLines = true;
            this.lvTercerosPorDNI.Location = new System.Drawing.Point(333, 115);
            this.lvTercerosPorDNI.MultiSelect = false;
            this.lvTercerosPorDNI.Name = "lvTercerosPorDNI";
            this.lvTercerosPorDNI.Size = new System.Drawing.Size(490, 12);
            this.lvTercerosPorDNI.TabIndex = 15;
            this.lvTercerosPorDNI.UseCompatibleStateImageBehavior = false;
            this.lvTercerosPorDNI.View = System.Windows.Forms.View.Details;
            this.lvTercerosPorDNI.Visible = false;
            this.lvTercerosPorDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvTercerosPorDNI_KeyPress);
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.LightBlue;
            this.pnlTotal.Controls.Add(this.label26);
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(this.lblIgv);
            this.pnlTotal.Controls.Add(this.label25);
            this.pnlTotal.Controls.Add(this.txtIgv);
            this.pnlTotal.Controls.Add(this.label14);
            this.pnlTotal.Controls.Add(this.label23);
            this.pnlTotal.Controls.Add(this.label22);
            this.pnlTotal.Controls.Add(this.lblEnLetras);
            this.pnlTotal.Controls.Add(this.txtNeto);
            this.pnlTotal.Controls.Add(this.label20);
            this.pnlTotal.Controls.Add(this.label15);
            this.pnlTotal.Location = new System.Drawing.Point(80, 457);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(703, 82);
            this.pnlTotal.TabIndex = 14;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(486, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 16);
            this.label26.TabIndex = 13;
            this.label26.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(585, 57);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(106, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIgv
            // 
            this.lblIgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIgv.AutoSize = true;
            this.lblIgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgv.Location = new System.Drawing.Point(538, 32);
            this.lblIgv.Name = "lblIgv";
            this.lblIgv.Size = new System.Drawing.Size(21, 16);
            this.lblIgv.TabIndex = 11;
            this.lblIgv.Text = "%";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(487, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 16);
            this.label25.TabIndex = 10;
            this.label25.Text = "I.G.V :";
            // 
            // txtIgv
            // 
            this.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIgv.Location = new System.Drawing.Point(585, 31);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(106, 20);
            this.txtIgv.TabIndex = 9;
            this.txtIgv.Text = "0.00";
            this.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(536, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "S/.";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(534, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 16);
            this.label23.TabIndex = 8;
            this.label23.Text = "S/.";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(487, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 16);
            this.label22.TabIndex = 7;
            this.label22.Text = "Neto :";
            // 
            // lblEnLetras
            // 
            this.lblEnLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnLetras.Location = new System.Drawing.Point(47, 10);
            this.lblEnLetras.Name = "lblEnLetras";
            this.lblEnLetras.Size = new System.Drawing.Size(430, 63);
            this.lblEnLetras.TabIndex = 7;
            this.lblEnLetras.Text = ".:.";
            // 
            // txtNeto
            // 
            this.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto.Location = new System.Drawing.Point(585, 5);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(106, 20);
            this.txtNeto.TabIndex = 6;
            this.txtNeto.Text = "0.00";
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 16);
            this.label20.TabIndex = 6;
            this.label20.Text = "Son: ";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(560, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "%";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPrincipal.Controls.Add(this.lblTipoTransaccion);
            this.pnlPrincipal.Controls.Add(this.txtNumero);
            this.pnlPrincipal.Controls.Add(this.gbCliente);
            this.pnlPrincipal.Controls.Add(this.txtSerie);
            this.pnlPrincipal.Controls.Add(this.dtpFechaPago);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.dtpFechaEmision);
            this.pnlPrincipal.Controls.Add(this.cboMoneda);
            this.pnlPrincipal.Controls.Add(this.cboTipoDocumento);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.label9);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Location = new System.Drawing.Point(6, 7);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(920, 160);
            this.pnlPrincipal.TabIndex = 7;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.LightBlue;
            this.gbCliente.Controls.Add(this.txtTercero);
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.label16);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.label8);
            this.gbCliente.Controls.Add(this.txtIdentificacion);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.btnTerceros);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCliente.Location = new System.Drawing.Point(265, 40);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(585, 109);
            this.gbCliente.TabIndex = 6;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos Cliente:";
            // 
            // txtTercero
            // 
            this.txtTercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTercero.Location = new System.Drawing.Point(115, 19);
            this.txtTercero.Name = "txtTercero";
            this.txtTercero.Size = new System.Drawing.Size(349, 20);
            this.txtTercero.TabIndex = 4;
            this.txtTercero.TextChanged += new System.EventHandler(this.txtTercero_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(404, 50);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(123, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Razn Soc:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "DNI / RUC :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefono:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentificacion.Location = new System.Drawing.Point(150, 50);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(136, 20);
            this.txtIdentificacion.TabIndex = 2;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(150, 80);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(377, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // btnTerceros
            // 
            this.btnTerceros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTerceros.BackColor = System.Drawing.Color.White;
            this.btnTerceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerceros.Location = new System.Drawing.Point(504, 18);
            this.btnTerceros.Name = "btnTerceros";
            this.btnTerceros.Size = new System.Drawing.Size(23, 23);
            this.btnTerceros.TabIndex = 2;
            this.btnTerceros.Text = "...";
            this.btnTerceros.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Direccion:";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaPago.CustomFormat = "aaaa-mm-dd";
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(678, 12);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaPago.TabIndex = 7;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaEmision.CustomFormat = "aaaa-mm-dd";
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(429, 14);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaEmision.TabIndex = 6;
            // 
            // cboMoneda
            // 
            this.cboMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(62, 129);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(169, 21);
            this.cboMoneda.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Moneda :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fecha Pago:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Emision:";
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.LightBlue;
            this.pnlProductos.Controls.Add(this.dgvExistencias);
            this.pnlProductos.Controls.Add(this.dgvProdcutos);
            this.pnlProductos.Location = new System.Drawing.Point(80, 235);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(846, 216);
            this.pnlProductos.TabIndex = 4;
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.AllowUserToAddRows = false;
            this.dgvExistencias.AllowUserToDeleteRows = false;
            this.dgvExistencias.AllowUserToResizeRows = false;
            this.dgvExistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExistencias.BackgroundColor = System.Drawing.Color.White;
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMercaderia_existencia,
            this.idExistencia_existencia,
            this.Codigo_mercaderia});
            this.dgvExistencias.Location = new System.Drawing.Point(706, 4);
            this.dgvExistencias.MultiSelect = false;
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.ReadOnly = true;
            this.dgvExistencias.RowHeadersVisible = false;
            this.dgvExistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExistencias.Size = new System.Drawing.Size(134, 209);
            this.dgvExistencias.TabIndex = 1;
            this.dgvExistencias.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvExistencias_RowsRemoved);
            this.dgvExistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvExistencias_KeyPress);
            // 
            // idMercaderia_existencia
            // 
            this.idMercaderia_existencia.HeaderText = "idMercaderia_existencia";
            this.idMercaderia_existencia.Name = "idMercaderia_existencia";
            this.idMercaderia_existencia.ReadOnly = true;
            this.idMercaderia_existencia.Visible = false;
            // 
            // idExistencia_existencia
            // 
            this.idExistencia_existencia.HeaderText = "idExistencia";
            this.idExistencia_existencia.Name = "idExistencia_existencia";
            this.idExistencia_existencia.ReadOnly = true;
            this.idExistencia_existencia.Visible = false;
            // 
            // Codigo_mercaderia
            // 
            this.Codigo_mercaderia.HeaderText = "Codigo";
            this.Codigo_mercaderia.Name = "Codigo_mercaderia";
            this.Codigo_mercaderia.ReadOnly = true;
            // 
            // dgvProdcutos
            // 
            this.dgvProdcutos.AllowUserToAddRows = false;
            this.dgvProdcutos.AllowUserToDeleteRows = false;
            this.dgvProdcutos.AllowUserToOrderColumns = true;
            this.dgvProdcutos.AllowUserToResizeRows = false;
            this.dgvProdcutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdcutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdcutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdcutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Mercaderia,
            this.PrecioUnitario,
            this.Cantidad,
            this.SubTotal,
            this.Descuento,
            this.Total,
            this.stockDisponible});
            this.dgvProdcutos.Location = new System.Drawing.Point(3, 4);
            this.dgvProdcutos.MultiSelect = false;
            this.dgvProdcutos.Name = "dgvProdcutos";
            this.dgvProdcutos.ReadOnly = true;
            this.dgvProdcutos.RowHeadersVisible = false;
            this.dgvProdcutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdcutos.Size = new System.Drawing.Size(700, 209);
            this.dgvProdcutos.TabIndex = 0;
            this.dgvProdcutos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProdcutos_RowsRemoved);
            this.dgvProdcutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProdcutos_KeyPress);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // Mercaderia
            // 
            this.Mercaderia.HeaderText = "Mercaderia";
            this.Mercaderia.Name = "Mercaderia";
            this.Mercaderia.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // stockDisponible
            // 
            this.stockDisponible.DataPropertyName = "stock";
            this.stockDisponible.HeaderText = "stock";
            this.stockDisponible.Name = "stockDisponible";
            this.stockDisponible.ReadOnly = true;
            this.stockDisponible.Visible = false;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Location = new System.Drawing.Point(6, 253);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(68, 265);
            this.pnlBotones.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.MintCream;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Ventas_Milton.Properties.Resources.imprimir00;
            this.btnImprimir.Location = new System.Drawing.Point(4, 201);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(60, 60);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Ventas_Milton.Properties.Resources.guardar00;
            this.btnCancelar.Location = new System.Drawing.Point(4, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Ventas_Milton.Properties.Resources.check01;
            this.btnGuardar.Location = new System.Drawing.Point(4, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 60);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::Ventas_Milton.Properties.Resources.nuevo02;
            this.btnNuevo.Location = new System.Drawing.Point(4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(38, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(781, 30);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = ".:FrmVentas:.";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Ventas_Milton.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(894, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Ventas_Milton.Properties.Resources.Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(860, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 23);
            this.btnMaximizar.TabIndex = 11;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::Ventas_Milton.Properties.Resources.Minimizar;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(825, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 23);
            this.btnMinimizar.TabIndex = 12;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ventas_Milton.Properties.Resources.Ventas;
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(945, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmVentas_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmVentas_MouseUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.pnlProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdcutos)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodBarras;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTipoTransaccion;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblEnLetras;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvProdcutos;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTercero;
        private System.Windows.Forms.Button btnTerceros;
        private System.Windows.Forms.ListView lvTercerosPorDNI;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.Label lblIgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvExistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMercaderia_existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExistencia_existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_mercaderia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mercaderia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDisponible;
    }
}