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
using Ventas_Milton.Entidades;

namespace Ventas_Milton.Vista
{
    public partial class frmControlProduccion : Form
    {
        funciones f = new funciones();
        Manejador_Factores mf = new Manejador_Factores();
        csFactores factor = new csFactores();
        Manejador_ControlProceso mcp = new Manejador_ControlProceso();
        static int yyyy = System.DateTime.Today.Year;
        static int MM = System.DateTime.Today.Month;
        static int dd = System.DateTime.Today.Day;
        static DateTime fecha = new DateTime(yyyy, MM, dd);
        int codigoProceso,codProduccion,idRegistro,contador=0;

        public frmControlProduccion(int codProd)
        {
            InitializeComponent();
            groupBox1.Paint += PaintBorderlessGroupBox;
            factor.Tabla = "5";
            codProduccion = codProd;
            f.CargarDataGrid(mf.BuscarFactor("Tabla", factor),dgrProcesos);
            dgrDetalleProcesos.Columns["Estado"].DisplayIndex = 6;
        }
        

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void dgrProcesos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoProceso = int.Parse(dgrProcesos.Rows[dgrProcesos.CurrentRow.Index].Cells["Codigo"].Value.ToString());
            int numReg;
            csRegistroDeProcesos rp = new csRegistroDeProcesos();
            rp.IdProceso = codigoProceso;
            rp.IdProduccion = codProduccion;
            DataTable dt = new DataTable();
            dt = mcp.BuscarRegistroDeProceso("Registros", rp);
            numReg = dt.Rows.Count;
            if (numReg == 0)
            {
                frmMessageBox mb = new frmMessageBox("Este Proceso No ha sido iniciado,\n Debe iniciarlo para revisar su registro de actividades");
                mb.Show();
            }
            else 
            {
                CargarRegistros();
            }
        }

        private void CargarRegistros()
        {
            csRegistroDeProcesos rp = new csRegistroDeProcesos();
            rp.IdProceso = codigoProceso;
            rp.IdProduccion = codProduccion;
            DataTable dt = new DataTable();
            dt = mcp.BuscarRegistroDeProceso("Registros", rp);
            f.CargarDataGrid(dt, dgrDetalleProcesos);
            dgrDetalleProcesos.Columns["Estado"].DisplayIndex = 6;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            csRegistroDeProcesos rp = new csRegistroDeProcesos();
            rp.IdProceso = codigoProceso;
            rp.IdProduccion = codProduccion;
            DataTable dt = new DataTable();
            dt = mcp.BuscarRegistroDeProceso("Registros", rp);

            csRegistroDeProcesos registroProceso = new csRegistroDeProcesos();
            registroProceso.HoraInicioReinicio = DateTime.Now.ToShortTimeString();
            registroProceso.Fecha = fecha;
            registroProceso.IdProceso = codigoProceso;
            registroProceso.IdProduccion = codProduccion;            
            if (contador == 1)
            {
                if (dt.Rows[0]["Estado"].ToString() == "DETENIDO") 
                {
                    //registroProceso.Tarea = dgrDetalleProcesos.Rows[dgrDetalleProcesos.Rows.Count - 1].Cells["TareaActual"].Value.ToString();
                    registroProceso.Estado = "REINICIADO"; 
                }
                else 
                {
                    registroProceso.Tarea = Tarea(idRegistro);
                    registroProceso.Estado = "INICIADO"; 
                }
            }
            else 
            {
                registroProceso.Estado = "INICIADO"; 
                registroProceso.Tarea = Tarea(idRegistro);
            }    
            contador++;
            registroProceso.Tarea = Tarea(idRegistro);
            idRegistro = mcp.RegistrarRegistroDeProceso(registroProceso);            
            CargarRegistros();
        }
        private string Tarea(int idReg) 
        {
            string TareaSeleccionada;
            frmTareas ft = new frmTareas(idReg);
            ft.Show();
            TareaSeleccionada = ft.Tarea;
            return TareaSeleccionada;
        }
        private void btnDetener_Click(object sender, EventArgs e)
        {
            csRegistroDeProcesos registroProceso = new csRegistroDeProcesos();            
            registroProceso.Finalizacion = DateTime.Now.ToShortTimeString();
            registroProceso.IdProceso = codigoProceso;
            registroProceso.IdProduccion = codProduccion;
            registroProceso.Estado = "DETENIDO";
            registroProceso.IdControlProduccion = idRegistro;
            mcp.ActualizarRegistroDeProceso("HoraFinalizacion",registroProceso);
            mcp.ActualizarRegistroDeProceso("Estado", registroProceso);
            CargarRegistros();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FinalizarTarea();
        }
        private void FinalizarTarea() 
        {
            csRegistroDeProcesos registroProceso = new csRegistroDeProcesos();
            registroProceso.Finalizacion = DateTime.Now.ToShortTimeString();
            registroProceso.IdProceso = codigoProceso;
            registroProceso.IdProduccion = codProduccion;
            registroProceso.Estado = "FINALIZADO";
            registroProceso.IdControlProduccion = idRegistro;
            mcp.ActualizarRegistroDeProceso("HoraFinalizacion", registroProceso);
            mcp.ActualizarRegistroDeProceso("Estado", registroProceso);
            CargarRegistros();
        }
        private void btnFinalizarYContinuar_Click(object sender, EventArgs e)
        {
            FinalizarTarea();
            Procesos frmP = new Procesos();
            frmP.Show();
            int idProceso = frmP.Nomproceso1;
        }

        private void frmControlProduccion_Load(object sender, EventArgs e)
        {

        }
    }
}
