namespace Ventas_Milton.Vista
{
    partial class frmControlProduccion
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrProcesos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrDetalleProcesos = new System.Windows.Forms.DataGridView();
            this.idProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareaActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizarYContinuar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProcesos)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDetalleProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(951, 30);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = ".:Frm Control de Producción:.";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.pnlBotones);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(5, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 276);
            this.panel1.TabIndex = 22;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(940, 22);
            this.statusStrip1.TabIndex = 31;
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
            this.pnlBotones.Location = new System.Drawing.Point(7, 6);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(68, 191);
            this.pnlBotones.TabIndex = 6;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Location = new System.Drawing.Point(81, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 245);
            this.panel3.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.panel2);
            this.groupBox7.Controls.Add(this.panel4);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(847, 239);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Control de Procesos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.dgrProcesos);
            this.panel2.Location = new System.Drawing.Point(7, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 219);
            this.panel2.TabIndex = 3;
            // 
            // dgrProcesos
            // 
            this.dgrProcesos.AllowUserToAddRows = false;
            this.dgrProcesos.AllowUserToDeleteRows = false;
            this.dgrProcesos.AllowUserToOrderColumns = true;
            this.dgrProcesos.AllowUserToResizeRows = false;
            this.dgrProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrProcesos.BackgroundColor = System.Drawing.Color.White;
            this.dgrProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Proceso,
            this.Monto,
            this.Eliminado,
            this.Tabla});
            this.dgrProcesos.Location = new System.Drawing.Point(5, 3);
            this.dgrProcesos.Name = "dgrProcesos";
            this.dgrProcesos.ReadOnly = true;
            this.dgrProcesos.RowHeadersVisible = false;
            this.dgrProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrProcesos.Size = new System.Drawing.Size(156, 213);
            this.dgrProcesos.TabIndex = 1;
            this.dgrProcesos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrProcesos_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idFactores";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Proceso
            // 
            this.Proceso.DataPropertyName = "concepto";
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            this.Proceso.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Visible = false;
            // 
            // Eliminado
            // 
            this.Eliminado.DataPropertyName = "Eliminado";
            this.Eliminado.HeaderText = "Eliminado";
            this.Eliminado.Name = "Eliminado";
            this.Eliminado.ReadOnly = true;
            this.Eliminado.Visible = false;
            // 
            // Tabla
            // 
            this.Tabla.DataPropertyName = "t";
            this.Tabla.HeaderText = "Tabla";
            this.Tabla.Name = "Tabla";
            this.Tabla.ReadOnly = true;
            this.Tabla.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btnFinalizarYContinuar);
            this.panel4.Controls.Add(this.btnFinalizar);
            this.panel4.Controls.Add(this.btnIniciar);
            this.panel4.Controls.Add(this.btnDetener);
            this.panel4.Location = new System.Drawing.Point(174, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(667, 219);
            this.panel4.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgrDetalleProcesos);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 178);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre de Procesos Seleccionado";
            // 
            // dgrDetalleProcesos
            // 
            this.dgrDetalleProcesos.AllowUserToAddRows = false;
            this.dgrDetalleProcesos.AllowUserToDeleteRows = false;
            this.dgrDetalleProcesos.AllowUserToOrderColumns = true;
            this.dgrDetalleProcesos.AllowUserToResizeRows = false;
            this.dgrDetalleProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrDetalleProcesos.BackgroundColor = System.Drawing.Color.White;
            this.dgrDetalleProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDetalleProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduccion,
            this.CodProceso,
            this.FechaProceso,
            this.TareaActual,
            this.HoraRI,
            this.HoraDF,
            this.Estado});
            this.dgrDetalleProcesos.Location = new System.Drawing.Point(6, 19);
            this.dgrDetalleProcesos.Name = "dgrDetalleProcesos";
            this.dgrDetalleProcesos.ReadOnly = true;
            this.dgrDetalleProcesos.RowHeadersVisible = false;
            this.dgrDetalleProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDetalleProcesos.Size = new System.Drawing.Size(647, 153);
            this.dgrDetalleProcesos.TabIndex = 2;
            // 
            // idProduccion
            // 
            this.idProduccion.DataPropertyName = "CodProduccion";
            this.idProduccion.HeaderText = "CodProduccion";
            this.idProduccion.Name = "idProduccion";
            this.idProduccion.ReadOnly = true;
            this.idProduccion.Visible = false;
            // 
            // CodProceso
            // 
            this.CodProceso.DataPropertyName = "CodProceso";
            this.CodProceso.HeaderText = "CodProceso";
            this.CodProceso.Name = "CodProceso";
            this.CodProceso.ReadOnly = true;
            this.CodProceso.Visible = false;
            // 
            // FechaProceso
            // 
            this.FechaProceso.DataPropertyName = "Fecha";
            this.FechaProceso.HeaderText = "Fecha";
            this.FechaProceso.Name = "FechaProceso";
            this.FechaProceso.ReadOnly = true;
            // 
            // TareaActual
            // 
            this.TareaActual.DataPropertyName = "Tarea";
            this.TareaActual.HeaderText = "Tarea";
            this.TareaActual.Name = "TareaActual";
            this.TareaActual.ReadOnly = true;
            // 
            // HoraRI
            // 
            this.HoraRI.DataPropertyName = "Hora R/I";
            this.HoraRI.HeaderText = "Hora R/I";
            this.HoraRI.Name = "HoraRI";
            this.HoraRI.ReadOnly = true;
            // 
            // HoraDF
            // 
            this.HoraDF.DataPropertyName = "Hora D/F";
            this.HoraDF.HeaderText = "Hora D/F";
            this.HoraDF.Name = "HoraDF";
            this.HoraDF.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnFinalizarYContinuar
            // 
            this.btnFinalizarYContinuar.BackColor = System.Drawing.Color.White;
            this.btnFinalizarYContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarYContinuar.Location = new System.Drawing.Point(540, 190);
            this.btnFinalizarYContinuar.Name = "btnFinalizarYContinuar";
            this.btnFinalizarYContinuar.Size = new System.Drawing.Size(123, 23);
            this.btnFinalizarYContinuar.TabIndex = 7;
            this.btnFinalizarYContinuar.Text = "Finalizar y Continuar";
            this.btnFinalizarYContinuar.UseVisualStyleBackColor = false;
            this.btnFinalizarYContinuar.Click += new System.EventHandler(this.btnFinalizarYContinuar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Location = new System.Drawing.Point(459, 190);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(297, 190);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.White;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Location = new System.Drawing.Point(378, 190);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 5;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Ventas_Milton.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(895, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 23);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Ventas_Milton.Properties.Resources.Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(861, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 23);
            this.btnMaximizar.TabIndex = 20;
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
            this.btnMinimizar.Location = new System.Drawing.Point(826, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 23);
            this.btnMinimizar.TabIndex = 21;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodProduccion";
            this.dataGridViewTextBoxColumn1.FillWeight = 76.14214F;
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoProduccion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // frmControlProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(951, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmControlProduccion";
            this.Text = "frmControlProduccion";
            this.Load += new System.EventHandler(this.frmControlProduccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProcesos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDetalleProcesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgrProcesos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFinalizarYContinuar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgrDetalleProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareaActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}