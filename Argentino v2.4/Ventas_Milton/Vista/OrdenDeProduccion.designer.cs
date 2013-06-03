namespace Ventas_Milton.Vista
{
    partial class OrdenDeProduccion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGenerarOrdProd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNroOrdProd = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.nudCantidadAProducir = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnMostrarOrdProd = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgrEnProduccion = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FchRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAProducir)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEnProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(2, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(790, 30);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = ".:Frm Orden de Producción:.";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.pnlBotones);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlProductos);
            this.panel1.Location = new System.Drawing.Point(7, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 487);
            this.panel1.TabIndex = 26;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(16, 17);
            this.lblEstado.Text = "...";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnImprimir);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Location = new System.Drawing.Point(5, 189);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(68, 191);
            this.pnlBotones.TabIndex = 29;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 178);
            this.panel2.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Produccion";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.btnGenerarOrdProd);
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.dtpFechaEntrega);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtNombreDelProducto);
            this.panel4.Controls.Add(this.nudCantidadAProducir);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(6, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 83);
            this.panel4.TabIndex = 1;
            // 
            // btnGenerarOrdProd
            // 
            this.btnGenerarOrdProd.BackColor = System.Drawing.Color.White;
            this.btnGenerarOrdProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarOrdProd.Location = new System.Drawing.Point(600, 45);
            this.btnGenerarOrdProd.Name = "btnGenerarOrdProd";
            this.btnGenerarOrdProd.Size = new System.Drawing.Size(116, 23);
            this.btnGenerarOrdProd.TabIndex = 35;
            this.btnGenerarOrdProd.Text = "Generar Ord. Prod.";
            this.btnGenerarOrdProd.UseVisualStyleBackColor = false;
            this.btnGenerarOrdProd.Click += new System.EventHandler(this.btnGenerarOrdProd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblNroOrdProd);
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 62);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Codigo de Ord. Prod.";
            // 
            // lblNroOrdProd
            // 
            this.lblNroOrdProd.AutoSize = true;
            this.lblNroOrdProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroOrdProd.Location = new System.Drawing.Point(15, 17);
            this.lblNroOrdProd.Name = "lblNroOrdProd";
            this.lblNroOrdProd.Size = new System.Drawing.Size(89, 37);
            this.lblNroOrdProd.TabIndex = 0;
            this.lblNroOrdProd.Text = "0000";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(470, 46);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaEntrega.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha de Entrega:";
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(251, 17);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(465, 20);
            this.txtNombreDelProducto.TabIndex = 35;
            // 
            // nudCantidadAProducir
            // 
            this.nudCantidadAProducir.Location = new System.Drawing.Point(251, 46);
            this.nudCantidadAProducir.Name = "nudCantidadAProducir";
            this.nudCantidadAProducir.Size = new System.Drawing.Size(79, 20);
            this.nudCantidadAProducir.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad a Producir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Producto:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(6, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 56);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 50);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de Productos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(597, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 28);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parámetro:";
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.LightBlue;
            this.pnlProductos.Controls.Add(this.btnMostrarOrdProd);
            this.pnlProductos.Controls.Add(this.groupBox7);
            this.pnlProductos.Location = new System.Drawing.Point(79, 189);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(691, 273);
            this.pnlProductos.TabIndex = 27;
            // 
            // btnMostrarOrdProd
            // 
            this.btnMostrarOrdProd.BackColor = System.Drawing.Color.White;
            this.btnMostrarOrdProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarOrdProd.Location = new System.Drawing.Point(569, 243);
            this.btnMostrarOrdProd.Name = "btnMostrarOrdProd";
            this.btnMostrarOrdProd.Size = new System.Drawing.Size(109, 23);
            this.btnMostrarOrdProd.TabIndex = 34;
            this.btnMostrarOrdProd.Text = "Mostrar Ord. Prod.";
            this.btnMostrarOrdProd.UseVisualStyleBackColor = false;
            this.btnMostrarOrdProd.Click += new System.EventHandler(this.btnMostrarOrdProd_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.dgrEnProduccion);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(679, 231);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lista de Ordenes de Producción:";
            // 
            // dgrEnProduccion
            // 
            this.dgrEnProduccion.AllowUserToAddRows = false;
            this.dgrEnProduccion.AllowUserToDeleteRows = false;
            this.dgrEnProduccion.AllowUserToOrderColumns = true;
            this.dgrEnProduccion.AllowUserToResizeRows = false;
            this.dgrEnProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrEnProduccion.BackgroundColor = System.Drawing.Color.White;
            this.dgrEnProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEnProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.FchRegistro,
            this.NroOP,
            this.SerieProducto,
            this.EstadoProd,
            this.Cantidad,
            this.Detalles});
            this.dgrEnProduccion.Location = new System.Drawing.Point(7, 16);
            this.dgrEnProduccion.Name = "dgrEnProduccion";
            this.dgrEnProduccion.ReadOnly = true;
            this.dgrEnProduccion.RowHeadersVisible = false;
            this.dgrEnProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrEnProduccion.Size = new System.Drawing.Size(665, 208);
            this.dgrEnProduccion.TabIndex = 1;
            this.dgrEnProduccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrEnProduccion_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codMercaderia";
            this.Codigo.FillWeight = 50F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // FchRegistro
            // 
            this.FchRegistro.DataPropertyName = "Fecha";
            this.FchRegistro.FillWeight = 96.59274F;
            this.FchRegistro.HeaderText = "Registro";
            this.FchRegistro.Name = "FchRegistro";
            this.FchRegistro.ReadOnly = true;
            // 
            // NroOP
            // 
            this.NroOP.DataPropertyName = "Ord. Prod.";
            this.NroOP.FillWeight = 97.8414F;
            this.NroOP.HeaderText = "N° Ord. Prod";
            this.NroOP.Name = "NroOP";
            this.NroOP.ReadOnly = true;
            // 
            // SerieProducto
            // 
            this.SerieProducto.DataPropertyName = "Serie";
            this.SerieProducto.FillWeight = 237.5612F;
            this.SerieProducto.HeaderText = "Producto";
            this.SerieProducto.Name = "SerieProducto";
            this.SerieProducto.ReadOnly = true;
            // 
            // EstadoProd
            // 
            this.EstadoProd.DataPropertyName = "Estado";
            this.EstadoProd.FillWeight = 86.73244F;
            this.EstadoProd.HeaderText = "Estado";
            this.EstadoProd.Name = "EstadoProd";
            this.EstadoProd.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Stock Disp.";
            this.Cantidad.FillWeight = 50.81523F;
            this.Cantidad.HeaderText = "Stock Disp.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Detalles
            // 
            this.Detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detalles.Text = "Ver Detalles";
            this.Detalles.UseColumnTextForButtonValue = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Ventas_Milton.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(740, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 23);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Ventas_Milton.Properties.Resources.Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(706, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 23);
            this.btnMaximizar.TabIndex = 24;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::Ventas_Milton.Properties.Resources.Minimizar;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(671, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 23);
            this.btnMinimizar.TabIndex = 25;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // OrdenDeProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(790, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenDeProduccion";
            this.Text = "OrdenDeProduccion";
            this.Load += new System.EventHandler(this.OrdenDeProduccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAProducir)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlProductos.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrEnProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgrEnProduccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.NumericUpDown nudCantidadAProducir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNroOrdProd;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarOrdProd;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGenerarOrdProd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FchRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
    }
}