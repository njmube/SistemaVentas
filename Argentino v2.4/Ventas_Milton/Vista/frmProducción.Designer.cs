namespace Ventas_Milton.Vista
{
    partial class frmProducción
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlProductosRacionamiento = new System.Windows.Forms.Panel();
            this.btnGuardar_Rac = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtXUndIntegra = new System.Windows.Forms.RadioButton();
            this.rbtXUndMedida = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbUndMedida = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblUndMedida = new System.Windows.Forms.Label();
            this.txtPrecioReferencia_Rac = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGanancia_Rac = new System.Windows.Forms.TextBox();
            this.txtNombreProducto_Racionamiento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrecioVenta_Rac = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlEmpaquetacion = new System.Windows.Forms.Panel();
            this.btnGuardar_Empq = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrProductosProduccion = new System.Windows.Forms.DataGridView();
            this.CodigoMerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MercaderiaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantXPaq = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.PrecioMerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorcGanancia = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.nudCantProducir = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioAcumulado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrSeleccionProductos = new System.Windows.Forms.DataGridView();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtRacionamiento = new System.Windows.Forms.RadioButton();
            this.rbtEmpaquetacion = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.pnlProductosRacionamiento.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pnlEmpaquetacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProductosProduccion)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantProducir)).BeginInit();
            this.pnlProducto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSeleccionProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(7, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1015, 30);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = ".:Frm Empaquetamiento y Racionamiento:.";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pnlProductosRacionamiento);
            this.panel4.Controls.Add(this.pnlEmpaquetacion);
            this.panel4.Controls.Add(this.pnlProducto);
            this.panel4.Controls.Add(this.pnlBotones);
            this.panel4.Controls.Add(this.statusStrip1);
            this.panel4.Location = new System.Drawing.Point(4, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1013, 348);
            this.panel4.TabIndex = 13;
            // 
            // pnlProductosRacionamiento
            // 
            this.pnlProductosRacionamiento.BackColor = System.Drawing.Color.LightBlue;
            this.pnlProductosRacionamiento.Controls.Add(this.btnGuardar_Rac);
            this.pnlProductosRacionamiento.Controls.Add(this.groupBox7);
            this.pnlProductosRacionamiento.Location = new System.Drawing.Point(488, 5);
            this.pnlProductosRacionamiento.Name = "pnlProductosRacionamiento";
            this.pnlProductosRacionamiento.Size = new System.Drawing.Size(516, 315);
            this.pnlProductosRacionamiento.TabIndex = 10;
            // 
            // btnGuardar_Rac
            // 
            this.btnGuardar_Rac.BackColor = System.Drawing.Color.White;
            this.btnGuardar_Rac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar_Rac.Location = new System.Drawing.Point(433, 287);
            this.btnGuardar_Rac.Name = "btnGuardar_Rac";
            this.btnGuardar_Rac.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar_Rac.TabIndex = 6;
            this.btnGuardar_Rac.Text = "Guardar";
            this.btnGuardar_Rac.UseVisualStyleBackColor = false;
            this.btnGuardar_Rac.Click += new System.EventHandler(this.btnGuardar_Rac_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.txtCategoria);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.cmbUndMedida);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.lblUndMedida);
            this.groupBox7.Controls.Add(this.txtPrecioReferencia_Rac);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.txtGanancia_Rac);
            this.groupBox7.Controls.Add(this.txtNombreProducto_Racionamiento);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txtPrecioVenta_Rac);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Location = new System.Drawing.Point(3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(510, 278);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Carácteristicas del Producto a Producir";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(115, 199);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(181, 20);
            this.txtCategoria.TabIndex = 51;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtXUndIntegra);
            this.groupBox5.Controls.Add(this.rbtXUndMedida);
            this.groupBox5.Location = new System.Drawing.Point(15, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(479, 44);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Seleccione base de precio:";
            // 
            // rbtXUndIntegra
            // 
            this.rbtXUndIntegra.AutoSize = true;
            this.rbtXUndIntegra.Checked = true;
            this.rbtXUndIntegra.Location = new System.Drawing.Point(100, 18);
            this.rbtXUndIntegra.Name = "rbtXUndIntegra";
            this.rbtXUndIntegra.Size = new System.Drawing.Size(114, 17);
            this.rbtXUndIntegra.TabIndex = 48;
            this.rbtXUndIntegra.TabStop = true;
            this.rbtXUndIntegra.Text = "Por Unidad Integra";
            this.rbtXUndIntegra.UseVisualStyleBackColor = true;
            this.rbtXUndIntegra.CheckedChanged += new System.EventHandler(this.rbtXUndIntegra_CheckedChanged);
            // 
            // rbtXUndMedida
            // 
            this.rbtXUndMedida.AutoSize = true;
            this.rbtXUndMedida.Location = new System.Drawing.Point(281, 18);
            this.rbtXUndMedida.Name = "rbtXUndMedida";
            this.rbtXUndMedida.Size = new System.Drawing.Size(131, 17);
            this.rbtXUndMedida.TabIndex = 49;
            this.rbtXUndMedida.Text = "Por Unidad de Medida";
            this.rbtXUndMedida.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Precio Calculado:";
            // 
            // cmbUndMedida
            // 
            this.cmbUndMedida.Enabled = false;
            this.cmbUndMedida.FormattingEnabled = true;
            this.cmbUndMedida.Items.AddRange(new object[] {
            "PESO",
            "UNIDAD"});
            this.cmbUndMedida.Location = new System.Drawing.Point(370, 158);
            this.cmbUndMedida.Name = "cmbUndMedida";
            this.cmbUndMedida.Size = new System.Drawing.Size(124, 21);
            this.cmbUndMedida.TabIndex = 46;
            this.cmbUndMedida.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 201);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Categoría:";
            // 
            // lblUndMedida
            // 
            this.lblUndMedida.AutoSize = true;
            this.lblUndMedida.Location = new System.Drawing.Point(287, 161);
            this.lblUndMedida.Name = "lblUndMedida";
            this.lblUndMedida.Size = new System.Drawing.Size(68, 13);
            this.lblUndMedida.TabIndex = 33;
            this.lblUndMedida.Text = "Und. Medida";
            this.lblUndMedida.Visible = false;
            // 
            // txtPrecioReferencia_Rac
            // 
            this.txtPrecioReferencia_Rac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioReferencia_Rac.Enabled = false;
            this.txtPrecioReferencia_Rac.Location = new System.Drawing.Point(140, 119);
            this.txtPrecioReferencia_Rac.Name = "txtPrecioReferencia_Rac";
            this.txtPrecioReferencia_Rac.Size = new System.Drawing.Size(127, 20);
            this.txtPrecioReferencia_Rac.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(112, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "S/.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nombre Producto: ";
            // 
            // txtGanancia_Rac
            // 
            this.txtGanancia_Rac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGanancia_Rac.Location = new System.Drawing.Point(388, 121);
            this.txtGanancia_Rac.Name = "txtGanancia_Rac";
            this.txtGanancia_Rac.Size = new System.Drawing.Size(96, 20);
            this.txtGanancia_Rac.TabIndex = 32;
            this.txtGanancia_Rac.TextChanged += new System.EventHandler(this.txtGanancia_Rac_TextChanged);
            // 
            // txtNombreProducto_Racionamiento
            // 
            this.txtNombreProducto_Racionamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto_Racionamiento.Location = new System.Drawing.Point(115, 29);
            this.txtNombreProducto_Racionamiento.Name = "txtNombreProducto_Racionamiento";
            this.txtNombreProducto_Racionamiento.Size = new System.Drawing.Size(379, 20);
            this.txtNombreProducto_Racionamiento.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Ganancia:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Precio Venta:";
            // 
            // txtPrecioVenta_Rac
            // 
            this.txtPrecioVenta_Rac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta_Rac.Enabled = false;
            this.txtPrecioVenta_Rac.Location = new System.Drawing.Point(140, 157);
            this.txtPrecioVenta_Rac.Name = "txtPrecioVenta_Rac";
            this.txtPrecioVenta_Rac.Size = new System.Drawing.Size(127, 20);
            this.txtPrecioVenta_Rac.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(112, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "S/.";
            // 
            // pnlEmpaquetacion
            // 
            this.pnlEmpaquetacion.BackColor = System.Drawing.Color.LightBlue;
            this.pnlEmpaquetacion.Controls.Add(this.btnGuardar_Empq);
            this.pnlEmpaquetacion.Controls.Add(this.groupBox2);
            this.pnlEmpaquetacion.Controls.Add(this.groupBox6);
            this.pnlEmpaquetacion.Location = new System.Drawing.Point(488, 5);
            this.pnlEmpaquetacion.Name = "pnlEmpaquetacion";
            this.pnlEmpaquetacion.Size = new System.Drawing.Size(516, 315);
            this.pnlEmpaquetacion.TabIndex = 6;
            this.pnlEmpaquetacion.Visible = false;
            // 
            // btnGuardar_Empq
            // 
            this.btnGuardar_Empq.BackColor = System.Drawing.Color.White;
            this.btnGuardar_Empq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar_Empq.Location = new System.Drawing.Point(432, 287);
            this.btnGuardar_Empq.Name = "btnGuardar_Empq";
            this.btnGuardar_Empq.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar_Empq.TabIndex = 6;
            this.btnGuardar_Empq.Text = "Guardar";
            this.btnGuardar_Empq.UseVisualStyleBackColor = false;
            this.btnGuardar_Empq.Click += new System.EventHandler(this.btnGuardar_Empq_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgrProductosProduccion);
            this.groupBox2.Location = new System.Drawing.Point(3, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 183);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Producto a Producir";
            // 
            // dgrProductosProduccion
            // 
            this.dgrProductosProduccion.AllowUserToAddRows = false;
            this.dgrProductosProduccion.AllowUserToDeleteRows = false;
            this.dgrProductosProduccion.AllowUserToOrderColumns = true;
            this.dgrProductosProduccion.AllowUserToResizeRows = false;
            this.dgrProductosProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrProductosProduccion.BackgroundColor = System.Drawing.Color.White;
            this.dgrProductosProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProductosProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMerc,
            this.MercaderiaProd,
            this.StockDisponible,
            this.CantXPaq,
            this.PrecioMerc});
            this.dgrProductosProduccion.Location = new System.Drawing.Point(6, 14);
            this.dgrProductosProduccion.Name = "dgrProductosProduccion";
            this.dgrProductosProduccion.RowHeadersVisible = false;
            this.dgrProductosProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrProductosProduccion.Size = new System.Drawing.Size(498, 163);
            this.dgrProductosProduccion.TabIndex = 0;
            // 
            // CodigoMerc
            // 
            this.CodigoMerc.HeaderText = "Codigo";
            this.CodigoMerc.Name = "CodigoMerc";
            this.CodigoMerc.Visible = false;
            // 
            // MercaderiaProd
            // 
            this.MercaderiaProd.DataPropertyName = "Mercaderia";
            this.MercaderiaProd.FillWeight = 178.0591F;
            this.MercaderiaProd.HeaderText = "Mercaderia";
            this.MercaderiaProd.Name = "MercaderiaProd";
            // 
            // StockDisponible
            // 
            this.StockDisponible.DataPropertyName = "Stock";
            this.StockDisponible.FillWeight = 47.05957F;
            this.StockDisponible.HeaderText = "Stock";
            this.StockDisponible.Name = "StockDisponible";
            this.StockDisponible.ReadOnly = true;
            // 
            // CantXPaq
            // 
            this.CantXPaq.FillWeight = 60.35901F;
            this.CantXPaq.HeaderText = "Cantidad";
            this.CantXPaq.Name = "CantXPaq";
            this.CantXPaq.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CantXPaq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PrecioMerc
            // 
            this.PrecioMerc.DataPropertyName = "Precio";
            this.PrecioMerc.HeaderText = "Precio";
            this.PrecioMerc.Name = "PrecioMerc";
            this.PrecioMerc.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtPorcGanancia);
            this.groupBox6.Controls.Add(this.txtNombreProducto);
            this.groupBox6.Controls.Add(this.nudCantProducir);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtPrecioVenta);
            this.groupBox6.Controls.Add(this.txtPrecioAcumulado);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(510, 92);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Carácteristicas del Producto a Producir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Producto: ";
            // 
            // txtPorcGanancia
            // 
            this.txtPorcGanancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcGanancia.Location = new System.Drawing.Point(398, 42);
            this.txtPorcGanancia.Name = "txtPorcGanancia";
            this.txtPorcGanancia.Size = new System.Drawing.Size(96, 20);
            this.txtPorcGanancia.TabIndex = 32;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Location = new System.Drawing.Point(111, 16);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(393, 20);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // nudCantProducir
            // 
            this.nudCantProducir.Location = new System.Drawing.Point(398, 68);
            this.nudCantProducir.Name = "nudCantProducir";
            this.nudCantProducir.Size = new System.Drawing.Size(96, 20);
            this.nudCantProducir.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ganancia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Precio Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Precio Acumulado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "S/.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Location = new System.Drawing.Point(137, 66);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(127, 20);
            this.txtPrecioVenta.TabIndex = 25;
            // 
            // txtPrecioAcumulado
            // 
            this.txtPrecioAcumulado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioAcumulado.Enabled = false;
            this.txtPrecioAcumulado.Location = new System.Drawing.Point(137, 40);
            this.txtPrecioAcumulado.Name = "txtPrecioAcumulado";
            this.txtPrecioAcumulado.Size = new System.Drawing.Size(127, 20);
            this.txtPrecioAcumulado.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "S/.";
            // 
            // pnlProducto
            // 
            this.pnlProducto.BackColor = System.Drawing.Color.LightBlue;
            this.pnlProducto.Controls.Add(this.groupBox3);
            this.pnlProducto.Controls.Add(this.groupBox1);
            this.pnlProducto.Controls.Add(this.groupBox4);
            this.pnlProducto.Location = new System.Drawing.Point(75, 5);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(410, 315);
            this.pnlProducto.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dgrSeleccionProductos);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(3, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 201);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Productos";
            // 
            // dgrSeleccionProductos
            // 
            this.dgrSeleccionProductos.AllowUserToAddRows = false;
            this.dgrSeleccionProductos.AllowUserToDeleteRows = false;
            this.dgrSeleccionProductos.AllowUserToOrderColumns = true;
            this.dgrSeleccionProductos.AllowUserToResizeRows = false;
            this.dgrSeleccionProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrSeleccionProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgrSeleccionProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSeleccionProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProducto,
            this.NomProducto,
            this.Stock,
            this.Precio});
            this.dgrSeleccionProductos.Location = new System.Drawing.Point(4, 17);
            this.dgrSeleccionProductos.Name = "dgrSeleccionProductos";
            this.dgrSeleccionProductos.ReadOnly = true;
            this.dgrSeleccionProductos.RowHeadersVisible = false;
            this.dgrSeleccionProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrSeleccionProductos.Size = new System.Drawing.Size(394, 178);
            this.dgrSeleccionProductos.TabIndex = 0;
            this.dgrSeleccionProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdcutos_CellContentClick);
            // 
            // CodProducto
            // 
            this.CodProducto.DataPropertyName = "Codigo";
            this.CodProducto.FillWeight = 122.787F;
            this.CodProducto.HeaderText = "Codigo";
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            this.CodProducto.Visible = false;
            // 
            // NomProducto
            // 
            this.NomProducto.DataPropertyName = "Mercaderia";
            this.NomProducto.FillWeight = 138.8735F;
            this.NomProducto.HeaderText = "Mercaderia";
            this.NomProducto.Name = "NomProducto";
            this.NomProducto.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.FillWeight = 38.29574F;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 61.1703F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbtRacionamiento);
            this.groupBox1.Controls.Add(this.rbtEmpaquetacion);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de Tipo de Produccion:";
            // 
            // rbtRacionamiento
            // 
            this.rbtRacionamiento.AutoSize = true;
            this.rbtRacionamiento.Location = new System.Drawing.Point(256, 22);
            this.rbtRacionamiento.Name = "rbtRacionamiento";
            this.rbtRacionamiento.Size = new System.Drawing.Size(96, 17);
            this.rbtRacionamiento.TabIndex = 1;
            this.rbtRacionamiento.Text = "Racionamiento";
            this.rbtRacionamiento.UseVisualStyleBackColor = true;
            // 
            // rbtEmpaquetacion
            // 
            this.rbtEmpaquetacion.AutoSize = true;
            this.rbtEmpaquetacion.Checked = true;
            this.rbtEmpaquetacion.Location = new System.Drawing.Point(70, 22);
            this.rbtEmpaquetacion.Name = "rbtEmpaquetacion";
            this.rbtEmpaquetacion.Size = new System.Drawing.Size(99, 17);
            this.rbtEmpaquetacion.TabIndex = 0;
            this.rbtEmpaquetacion.TabStop = true;
            this.rbtEmpaquetacion.Text = "Empaquetación";
            this.rbtEmpaquetacion.UseVisualStyleBackColor = true;
            this.rbtEmpaquetacion.CheckedChanged += new System.EventHandler(this.rbtEmpaquetacion_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.cmbCategoria);
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 55);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda de Productos";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(105, 21);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(212, 21);
            this.cmbCategoria.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(323, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Categoría:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Location = new System.Drawing.Point(4, 5);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(68, 191);
            this.pnlBotones.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.MintCream;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::Ventas_Milton.Properties.Resources.imprimir00;
            this.btnImprimir.Location = new System.Drawing.Point(4, 127);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(60, 60);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Ventas_Milton.Properties.Resources.guardar00;
            this.btnCancelar.Location = new System.Drawing.Point(4, 65);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(16, 17);
            this.lblEstado.Text = "...";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Ventas_Milton.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(968, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 23);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Ventas_Milton.Properties.Resources.Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(934, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 23);
            this.btnMaximizar.TabIndex = 16;
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
            this.btnMinimizar.Location = new System.Drawing.Point(899, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 23);
            this.btnMinimizar.TabIndex = 17;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // frmProducción
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1022, 389);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducción";
            this.Text = "frmProducción";
            this.Load += new System.EventHandler(this.frmProducción_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProducción_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProducción_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProducción_MouseUp);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlProductosRacionamiento.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pnlEmpaquetacion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProductosProduccion)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantProducir)).EndInit();
            this.pnlProducto.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSeleccionProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Panel pnlEmpaquetacion;
        private System.Windows.Forms.Button btnGuardar_Empq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrProductosProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MercaderiaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDisponible;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn CantXPaq;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMerc;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorcGanancia;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.NumericUpDown nudCantProducir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioAcumulado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrSeleccionProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlProductosRacionamiento;
        private System.Windows.Forms.Button btnGuardar_Rac;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGanancia_Rac;
        private System.Windows.Forms.TextBox txtNombreProducto_Racionamiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrecioVenta_Rac;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPrecioReferencia_Rac;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbUndMedida;
        private System.Windows.Forms.Label lblUndMedida;
        private System.Windows.Forms.RadioButton rbtRacionamiento;
        private System.Windows.Forms.RadioButton rbtEmpaquetacion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtXUndIntegra;
        private System.Windows.Forms.RadioButton rbtXUndMedida;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}