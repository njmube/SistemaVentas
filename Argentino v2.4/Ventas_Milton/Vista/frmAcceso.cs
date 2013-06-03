using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Manejadores;
using Ventas_Milton.Entidades;

namespace Ventas_Milton.Vista
{
    public partial class frmAcceso : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Manejador_Usuarios mu = new Manejador_Usuarios();
        static csUsuario u = new csUsuario();
        static csUsuarioAccion ua = new csUsuarioAccion();
        static DataTable dt = new DataTable();
        static DataTable dt2 = new DataTable();
        Manejador_AccionUsuario ma = new Manejador_AccionUsuario();

        public frmAcceso()
        {
            InitializeComponent();
            //txtHora.Text = DateTime.Now.ToShortTimeString();
            //panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            //panel1.Anchor = AnchorStyles.None;
            //txtFecha.Text = DateTime.Now.ToShortDateString();
            //panel4.Location = new Point(-65, 10);
        }

        private void frmAcceso_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void frmAcceso_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void frmAcceso_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            frmAcceso_MouseMove(sender, e);
        }
        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            frmAcceso_MouseUp(sender, e);
        }
        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            frmAcceso_MouseDown(sender,e);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //u.Login = txtUsuario.Text;
            //u.Clave = txtConstraseña.Text;
            //dt = mu.BuscarUsuario("Login", u);
            //if (dt.Rows[0]["Login"].ToString() == u.Login && dt.Rows[0]["Clave"].ToString() == u.Clave)
            //{
            //    if (int.Parse(dt.Rows[0]["Modo"].ToString()) != 1)
            //    {
            //        u.Modo = 1;
            //        u.IdUsuario = int.Parse(dt.Rows[0]["idUsuario"].ToString());
            //        mu.ActualizarRegistro_Usuario("Modo", u);
            //        dt2 = mu.BuscarUsuario("Login", u);
            //        //Registro de Accion de Usuario
            //        ma.Log("Usuarios", "Inicio de Sesión", u.IdUsuario, u.IdUsuario);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ya hay un usuario conectado a esa cuenta");
            //    }
            //} 
            
            //if (txtUsuario.Text.ToUpper() == "ADMIN" && txtConstraseña.Text == "123456") 
            //{
            //    frmPrincipal frmP = new frmPrincipal();
            //    frmP.Show();
            //    this.Visible = false;
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //u.Login = txtUsuario.Text;
            //u.Clave = txtConstraseña.Text;
            //dt = mu.BuscarUsuario("Login", u);
            //u.Modo = 0;
            //u.IdUsuario = int.Parse(dt.Rows[0]["idUsuario"].ToString());
            //mu.ActualizarRegistro_Usuario("Modo", u);
            //dt2 = mu.BuscarUsuario("Login", u);

            ////Registro de Accion de Usuario
            //ma.Log("Usuarios", "Termino de Sesión", u.IdUsuario, u.IdUsuario);
            this.Dispose();
            frmPrincipal frmP = new frmPrincipal();
            frmP.Dispose();
        }
        private void frmAcceso_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
