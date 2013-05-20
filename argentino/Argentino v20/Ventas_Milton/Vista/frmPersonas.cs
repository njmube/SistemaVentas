using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Manejadores;
using Ventas_Milton.Datos;

namespace Ventas_Milton.Vista
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
            personalizarVentana();
        }

        int tipoGuardado;
        public string param_tipoPersona;
        public int param_idPersona;
        public string accion_Ventana;

        funciones funciones = new funciones();
        Manejador_Persona mPersona = new Manejador_Persona();

        #region //////////////////////  Personalizar Ventana //////////////////////////////////

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        void personalizarVentana()
        {
            this.BackColor = Color.FromArgb(173, 216, 230);
            btnMinimizar.BackColor = Color.FromArgb(173, 216, 230);
            btnMaximizar.BackColor = Color.FromArgb(173, 216, 230);
            btnCerrar.BackColor = Color.FromArgb(199, 80, 80);
        }

        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnNuevo, 1, lblEstado, "Ingresar nuevo registro");
        }
        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnNuevo, 0, lblEstado, "");
        }
        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnModificar, 1, lblEstado, "Modificar registro seleccionado");
        }
        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnModificar, 0, lblEstado, "");
        }
        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnEliminar, 1, lblEstado, "Eliminar registro seleccionado");
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnEliminar, 0, lblEstado, "");
        }
        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnGuardar, 1, lblEstado, "Guardar");
        }
        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnGuardar, 0, lblEstado, "");
        }
        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnCancelar, 1, lblEstado, "Cancelar la operacion");
        }
        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnCancelar, 0, lblEstado, "");
        }
        private void btnImprimir_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnImprimir, 1, lblEstado, "Imprimir registros");
        }
        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnImprimir, 0, lblEstado, "");
        }
        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonColor(btnMinimizar, 62, 64, 149, Ventas_Milton.Properties.Resources._HoverMinimizar);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonColor(btnMinimizar, 173, 216, 230, Ventas_Milton.Properties.Resources.Minimizar);
        }
        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                funciones.AnimarButtonColor(btnMaximizar, 62, 64, 149, Ventas_Milton.Properties.Resources._hoverRestaurar);

            }
            else
            {
                funciones.AnimarButtonColor(btnMaximizar, 62, 64, 149, Ventas_Milton.Properties.Resources._HoverMaximizar);
            }
        }
        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                funciones.AnimarButtonColor(btnMaximizar, 173, 216, 230, Ventas_Milton.Properties.Resources.Restaurar);

            }
            else
            {

                funciones.AnimarButtonColor(btnMaximizar, 173, 216, 230, Ventas_Milton.Properties.Resources.Maximizar);
            }
        }
        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonColor(btnCerrar, 255, 11, 11, Ventas_Milton.Properties.Resources._HoverCerrar);
        }
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonColor(btnCerrar, 199, 80, 80, Ventas_Milton.Properties.Resources.Cerrar);
        }

        private void frmPersonas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }        
        private void frmPersonas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void frmPersonas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            frmPersonas_MouseDown(sender, e);
        }
        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            frmPersonas_MouseMove(sender, e);
        }
        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            frmPersonas_MouseUp(sender, e);
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtApellidos, 0);
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtApellidos, 1);
        }

        private void txtNumDocumento_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtNumDocumento, 0);
        }

        private void txtNumDocumento_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtNumDocumento, 1);
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtDireccion, 0);
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtDireccion, 1);
        }

        private void txtNombres_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtNombres, 0);
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtNombres, 1);
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtTelefono, 0);
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtTelefono, 1);
        }

        private void dtpFechaNacimiento_Enter(object sender, EventArgs e)
        {
            funciones.controlFocus(txtTelefono, 0);
        }

        private void dtpFechaNacimiento_Leave(object sender, EventArgs e)
        {
            funciones.controlFocus(txtTelefono, 1);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtBuscar, 0);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtBuscar, 1);
        }

        #endregion

        void inicio()
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = true;
            funciones.LimpiarTextBox(gbBuscar);
            funciones.LimpiarTextBox(pnlPrincipal);
            pnlBuscar.Enabled = true;
            pnlPrincipal.Enabled = false;
            pnlTabla.Enabled = true;
            tipoGuardado = 0;
            cargarDatosPrevios();
            txtBuscar.Focus();
        }
        void cargarDatosPrevios() {
            csPersona persona = new csPersona() ;
            persona.TipoIdentificacion = param_tipoPersona;
            funciones.CargarDataGrid(mPersona.BuscarMovimiento("TipoIdentificacion", persona), dgvPersonas);
        }
        void nuevo() {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            funciones.LimpiarTextBox(gbBuscar);
            funciones.LimpiarTextBox(pnlPrincipal);
            pnlBuscar.Enabled = false;
            pnlPrincipal.Enabled = true;
            pnlTabla.Enabled = false;
            tipoGuardado = 0;
            txtBuscar.Focus();
        }
        void modificar() {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            pnlBuscar.Enabled = false;
            pnlPrincipal.Enabled = true;
            pnlTabla.Enabled = false;
            tipoGuardado = 1;
            txtBuscar.Focus();
        }
        void eliminar() {
            if (dgvPersonas.CurrentRow == null)
            {
                MessageBox.Show("No a seleccionado ninguna fia, seleccione una fila");
            }
            csPersona persona = new csPersona();
            persona.IdPersona = param_idPersona;
            persona.Eliminado = 1;
            mPersona.ActualizarRegistro("Eliminar", persona);
            inicio();
        }

        void guardar()
        {
            csPersona p = new csPersona(0, txtNombres.Text, txtApellidos.Text, dtpFechaNacimiento.Value, txtDireccion.Text, txtTelefono.Text, txtNumDocumento.Text, param_tipoPersona);
            Manejador_Persona mp = new Manejador_Persona();
            if (tipoGuardado == 0)
            {
                
                int r = mp.RegistrarNuevaPersona(p);
                if (r > 0)
                {
                    lblEstado.Text = "Se agrego nuevo registro";
                }
                else if (r <= 0)
                {
                    lblEstado.Text = "No se agrego ningun registro";
                }
                inicio();
            }
            else if (tipoGuardado == 1)
            {
                p.IdPersona = param_idPersona;
                mp.ActualizarRegistro("SegundoNombre", p);
                mp.ActualizarRegistro("Nombre", p);
                mp.ActualizarRegistro("FechaNacimiento", p);
                mp.ActualizarRegistro("Direccion", p);
                mp.ActualizarRegistro("Telefono", p);
                mp.ActualizarRegistro("NroId", p);
                inicio();
            }

        }
        void cancelar() {
            inicio();
        }
        void imprimir() {

        }
        void seleccionar(){
            if (dgvPersonas.CurrentRow == null){
                return;
            }
            DataGridViewRow fila = new DataGridViewRow();
            fila = dgvPersonas.CurrentRow;
            param_idPersona = Convert.ToInt32(fila.Cells[0].Value);
            txtApellidos.Text = Convert.ToString(fila.Cells["segundoNombre"].Value);
            txtNombres.Text = Convert.ToString(fila.Cells["primeroNombre"].Value);
            txtNumDocumento.Text = Convert.ToString(fila.Cells["nroIdentificacion"].Value);
            dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["fechaNacimiento"].Value);
            txtDireccion.Text = Convert.ToString(fila.Cells["direccionRasonSocial"].Value);
            txtTelefono.Text = Convert.ToString( fila.Cells["telefono"].Value);

        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            inicio();
            if (accion_Ventana == "NUEVO")
            {
                nuevo();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (funciones.ElementoObligatorio(txtApellidos, "Campo de Ape/Rs es Obligatorio") == false) {
                return;
            }
            if (funciones.ElementoObligatorio(txtNumDocumento, "Campo de Dni/Ruc es obligatorio ") == false) {
                return;
            }
            guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized){

                this.WindowState = FormWindowState.Normal;
                btnMaximizar.Image = Ventas_Milton.Properties.Resources.Maximizar;

            }else {

                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Image = Ventas_Milton.Properties.Resources.Restaurar;
            }
        }

        private void lblTitulo_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
                btnMaximizar.Image = Ventas_Milton.Properties.Resources.Maximizar;

            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Image = Ventas_Milton.Properties.Resources.Restaurar;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbmRazonSocial.Checked == true)
            {
                DataTable x = (DataTable)dgvPersonas.DataSource;
                x.DefaultView.RowFilter = (" segundoNombre Like '%" + txtBuscar.Text + "%' or primerNombre Like '%" + txtBuscar.Text + "%' ");
            } 
            else if(rbmNumIdentificacion.Checked == true)
            {
                DataTable x = (DataTable)dgvPersonas.DataSource;
                x.DefaultView.RowFilter = (" nroIdentificacion Like '%" + txtBuscar.Text + "%' ");
            }

        }

        private void dgvPersonas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblTotalRegistros.Text = dgvPersonas.Rows.Count.ToString();
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void dgvPersonas_CurrentCellChanged(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        

           
    }
}
