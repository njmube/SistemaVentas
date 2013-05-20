using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using Ventas_Milton.Entidades;
using Ventas_Milton.Manejadores;

namespace Ventas_Milton.Vista
{
    public partial class frmPrincipal : Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private int h = SystemInformation.PrimaryMonitorSize.Height;
        private int w = SystemInformation.PrimaryMonitorSize.Width;
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr child, IntPtr newParent);

        static csUsuario u = new csUsuario();
        static Manejador_Usuarios mu = new Manejador_Usuarios();
        static Manejador_AccionUsuario ma = new Manejador_AccionUsuario();
        static DataTable dt = new DataTable();
        static DataTable dt2 = new DataTable();

        public frmPrincipal()
        {
            InitializeComponent();
            pnlMenu.Location = new Point(1300, 0);

            CambioLogin_Principal();
            this.WindowState = FormWindowState.Maximized;
        }

        #region /***************Perzonalizar Ventana *****************************/

        private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmPrincipal_MouseHover(object sender, EventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnlEscritorio_MouseHover(object sender, EventArgs e)
        {

        }

        private void pnlMenu_MouseHover(object sender, EventArgs e)
        {
            //for (int i = 2; pnlmenu.size.width <= 200; i = i + 3)
            //{
            //    pnlmenu.width = i;
            //    pnlmenu.height = h;
            //    pnlmenu.location = new point(w - i, 0);
            //    //pnlescritorio.width = w - pnlmenu.width;
            //}
        }


        ////////////////////////////////////////////////////////////////////////MENU PRINCIPAL
        private void btnCliente_Click(object sender, EventArgs e)
        {
            MostrarSubMenu_Clientes();
        }
        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu_Empleados();
        }
        private void btnVenta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu_Ventas();
        }
        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnRegresarVentas_Click(object sender, EventArgs e)
        {
            OcultarSubMenu_Ventas();
            MostrarMenuPrincipal();
            botonTituloReestructurar(btnVenta);
        }
        private void btnRegresarClientes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu_Clientes();
            MostrarMenuPrincipal();
            botonTituloReestructurar(btnCliente);
        }
        private void btnCompras_Click(object sender, EventArgs e)
        {
            MostrarSubMenu_Compras();
        }
        private void btnRegresarCompras_Click(object sender, EventArgs e)
        {
            OcultarSubMenu_Compras();
            MostrarMenuPrincipal();
            botonTituloReestructurar(btnCompras);
        }

        private void btnRegresar_Empleados_Click(object sender, EventArgs e)
        {
            OcultarSubMenu_Empleados();
            MostrarMenuPrincipal();
            botonTituloReestructurar(btnEmpleados);
        }
        private void btnTraspasos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu_Traspasos();
        }
        private void btnRegresar_Traspasos_Click(object sender, EventArgs e)
        {
            OcultarSubMenu_Traspasos();
            MostrarMenuPrincipal();
            botonTituloReestructurar(btnTraspasos);
        }
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 163; i++)
            {
                PSup.Location = new Point(-158 + i, 5);
                PInf.Location = new Point(-158 + i, 263);
            }
        }
        private void btnAvanzado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 163; i++)
            {
                PSup.Location = new Point(5 - i, 5);
                PInf.Location = new Point(5 - i, 263);
                //System.Threading.Thread.Sleep(5);
            }
        }
        private void btnMercaderia_Click(object sender, EventArgs e)
        {
            MostrarSubMenu_Mercaderia();
        }
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu_Produccion();
        }
        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            MostrarSubMenu_Almacen();
        }
        private void btnRegresar_Mercaderia_Click(object sender, EventArgs e)
        {
            OcultarSubMenu_Mercaderia();
            MostrarMenuPrincipal();
            botonTituloReestructurar(btnMercaderia);
        }
        private void btnRegresar_Produccion_Click(object sender, EventArgs e)
        {
            OcultarSubMenu_Produccion();
            MostrarMenuPrincipal();
            botonTituloReestructurar(btnProduccion);
        }
        private void btnRegresar_Almacen_Click(object sender, EventArgs e)
        {
            OcultarSubMenu_Almacen();
            MostrarMenuPrincipal();
            botonTituloReestructurar(btnAlmacen);
        }


        private void MostrarSubMenu_Almacen()
        {
            //OCULTAR MENU PRINCIPAL
            OcultarMenuPrincipal("Almacen");

            //CAMBIAR TAMANO A CONTENEDOR SUBMENU
            btnAlmacen.Width = 154;
            btnAlmacen.Location = new Point(5, 5);
            botonTituloCambiar(btnAlmacen);
            PInfCambiarTamano();

            //MOSTRAR BOTONES SUB MENU
            btnRegistrarAlmacen.Visible = true;
            btnRegistrarAlmacen.Location = new Point(5, 74);

            btnCardex.Visible = true;
            btnCardex.Location = new Point(83, 74);

            btnParametros_Almacen.Visible = true;
            btnParametros_Almacen.Location = new Point(5, 133);

            btnEstadisticas_Almacen.Visible = true;
            btnEstadisticas_Almacen.Location = new Point(83, 133);

            btnInformes_Almacen.Visible = true;
            btnInformes_Almacen.Location = new Point(5, 192);

            btnRegresar_Almacen.Visible = true;
            pnlRegresar_Almacen.Visible = true;
            pnlRegresar_Almacen.Location = new Point(5, 317);
        }
        private void OcultarSubMenu_Almacen()
        {
            btnRegistrarAlmacen.Visible = false;
            btnCardex.Visible = false;
            btnParametros_Almacen.Visible = false;
            btnEstadisticas_Almacen.Visible = false;
            btnInformes_Almacen.Visible = false;
            pnlRegresar_Almacen.Visible = false;
        }
        private void MostrarSubMenu_Produccion()
        {
            //OCULTAR MENU PRINCIPAL
            OcultarMenuPrincipal("Produccion");

            //CAMBIAR TAMANO A CONTENEDOR SUBMENU
            btnProduccion.Width = 154;
            btnProduccion.Location = new Point(5, 5);
            botonTituloCambiar(btnProduccion);
            PInfCambiarTamano();

            //MOSTRAR BOTONES SUB MENU
            btnOrdenProduccion.Visible = true;
            btnOrdenProduccion.Location = new Point(5, 74);

            btnInformes_Produccion.Visible = true;
            btnInformes_Produccion.Location = new Point(83, 74);

            btnParametros_Produccion.Visible = true;
            btnParametros_Produccion.Location = new Point(5, 133);

            btnEstadisticas_Produccion.Visible = true;
            btnEstadisticas_Produccion.Location = new Point(83, 133);

            btnRegresar_Produccion.Visible = true;
            pnlRegresar_Produccion.Visible = true;
            pnlRegresar_Produccion.Location = new Point(5, 317);
        }
        private void OcultarSubMenu_Produccion()
        {
            btnOrdenProduccion.Visible = false;
            btnInformes_Produccion.Visible = false;
            btnParametros_Produccion.Visible = false;
            btnEstadisticas_Produccion.Visible = false;
            btnRegresar_Produccion.Visible = false;
            pnlRegresar_Produccion.Visible = false;
        }
        private void MostrarSubMenu_Mercaderia()
        {
            //OCULTAR MENU PRINCIPAL
            OcultarMenuPrincipal("Mercaderias");

            //CAMBIAR TAMANO A CONTENEDOR SUBMENU
            btnMercaderia.Width = 154;
            btnMercaderia.Location = new Point(5, 5);
            botonTituloCambiar(btnMercaderia);
            PInfCambiarTamano();

            //MOSTRAR BOTONES SUB MENU
            btnRegistrarMercaderia.Visible = true;
            btnRegistrarMercaderia.Location = new Point(5, 74);

            btnInformes_Mercaderia.Visible = true;
            btnInformes_Mercaderia.Location = new Point(83, 74);

            btnRegistrarFamilia.Visible = true;
            btnRegistrarFamilia.Location = new Point(5, 133);

            btnEstadisticas_Mercaderia.Visible = true;
            btnEstadisticas_Mercaderia.Location = new Point(83, 133);

            btnArbolDeMercaderias.Visible = true;
            btnArbolDeMercaderias.Location = new Point(5, 192);

            btnRegresar_Mercaderia.Visible = true;
            pnlRegresar_Mercaderia.Visible = true;
            pnlRegresar_Mercaderia.Location = new Point(5, 317);
        }
        private void OcultarSubMenu_Mercaderia()
        {
            btnRegistrarMercaderia.Visible = false;
            btnInformes_Mercaderia.Visible = false;
            btnRegistrarFamilia.Visible = false;
            btnEstadisticas_Mercaderia.Visible = false;
            btnArbolDeMercaderias.Visible = false;
            pnlRegresar_Mercaderia.Visible = false;
        }
        private void MostrarSubMenu_Traspasos()
        {
            //OCULTAR MENU PRINCIPAL
            OcultarMenuPrincipal("Traspasos");

            //CAMBIAR TAMANO A CONTENEDOR SUBMENU
            btnTraspasos.Width = 154;
            btnTraspasos.Location = new Point(5, 5);
            botonTituloCambiar(btnTraspasos);
            PInfCambiarTamano();

            //MOSTRAR BOTONES SUB MENU
            btnRealizarTraspasos.Visible = true;
            btnRealizarTraspasos.Location = new Point(5, 74);

            btnInformes_Traspasos.Visible = true;
            btnInformes_Traspasos.Location = new Point(83, 74);

            btnEstadisticas_Traspasos.Visible = true;
            btnEstadisticas_Traspasos.Location = new Point(5, 133);

            btnParametros_Traspasos.Visible = true;
            btnParametros_Traspasos.Location = new Point(83, 133);

            btnRealizarTraspasos.Visible = true;
            pnlRegresar_Traspasos.Visible = true;
            pnlRegresar_Traspasos.Location = new Point(5, 317);
        }
        private void OcultarSubMenu_Traspasos()
        {
            btnRealizarTraspasos.Visible = false;
            btnInformes_Traspasos.Visible = false;
            btnEstadisticas_Traspasos.Visible = false;
            btnParametros_Traspasos.Visible = false;
            btnRealizarTraspasos.Visible = false;
            pnlRegresar_Traspasos.Visible = false;
        }
        private void MostrarSubMenu_Empleados()
        {
            //OCULTAR MENU PRINCIPAL
            OcultarMenuPrincipal("Empleados");

            //CAMBIAR TAMANO A CONTENEDOR SUBMENU
            btnEmpleados.Width = 154;
            btnEmpleados.Location = new Point(5, 5);
            botonTituloCambiar(btnEmpleados);
            PSupCambiarTamano();

            //MOSTRAR BOTONES SUB MENU
            btnRegistrarEmpleados.Visible = true;
            btnRegistrarEmpleados.Location = new Point(5, 74);

            btnConsultarEmpleados.Visible = true;
            btnConsultarEmpleados.Location = new Point(83, 74);

            btnEstadisticas_Empleados.Visible = true;
            btnEstadisticas_Empleados.Location = new Point(5, 133);

            btnParametros_Empleados.Visible = true;
            btnParametros_Empleados.Location = new Point(83, 133);

            btnRegresar_Empleados.Visible = true;
            pnlRegresar_Empleados.Visible = true;
            pnlRegresar_Empleados.Location = new Point(5, 317);
        }
        private void OcultarSubMenu_Empleados()
        {
            btnRegistrarEmpleados.Visible = false;
            btnConsultarEmpleados.Visible = false;
            btnEstadisticas_Empleados.Visible = false;
            btnParametros_Empleados.Visible = false;
            btnRegresar_Empleados.Visible = false;
        }
        private void MostrarSubMenu_Compras()
        {
            //OCULTAR MENU PRINCIPAL
            OcultarMenuPrincipal("Compras");

            //CAMBIAR TAMANO A CONTENEDOR SUBMENU
            btnCompras.Width = 154;
            btnCompras.Location = new Point(5, 5);
            botonTituloCambiar(btnCompras);
            PSupCambiarTamano();

            //MOSTRAR BOTONES SUB MENU
            btnRealizarCompra.Visible = true;
            btnRealizarCompra.Location = new Point(5, 74);

            btnInformes_Compras.Visible = true;
            btnInformes_Compras.Location = new Point(83, 74);

            btnParametros_Compras.Visible = true;
            btnParametros_Compras.Location = new Point(5, 133);

            btnEstadisticas_Compras.Visible = true;
            btnEstadisticas_Compras.Location = new Point(83, 133);

            btnRegresarCompras.Visible = true;
            pnlRegresarCompras.Visible = true;
            pnlRegresarCompras.Location = new Point(5, 317);
        }
        private void OcultarSubMenu_Compras()
        {
            btnRealizarCompra.Visible = false;
            btnInformes_Compras.Visible = false;
            btnParametros_Compras.Visible = false;
            btnEstadisticas_Compras.Visible = false;
            pnlRegresarCompras.Visible = false;
        }
        private void MostrarSubMenu_Clientes()
        {
            //OCULTAR MENU PRINCIPAL
            OcultarMenuPrincipal("Clientes");

            //CAMBIAR TAMANO A CONTENEDOR SUBMENU
            btnCliente.Width = 154;
            btnCliente.Location = new Point(5, 5);
            botonTituloCambiar(btnCliente);
            PSupCambiarTamano();

            //Mostrar BOTONES SUB MENU
            btnRegistrarCliente.Visible = true;
            btnRegistrarCliente.Location = new Point(5, 74);


            btnConsultarClientes.Visible = true;
            btnConsultarClientes.Location = new Point(83, 74);

            btnInformesClientes.Visible = true;
            btnInformesClientes.Location = new Point(5, 133);

            btnMailing.Visible = true;
            btnMailing.Location = new Point(83, 133);

            pnlRegresarClientes.Visible = true;
            btnRegresarClientes.Visible = true;
            pnlRegresarClientes.Location = new Point(5, 317);
        }

        private void botonTituloCambiar(Button boton) {
            boton.TextImageRelation = TextImageRelation.ImageBeforeText;
            boton.TextAlign = this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }

        private void botonTituloReestructurar(Button boton)
        {
            boton.TextImageRelation = TextImageRelation.ImageAboveText;
            boton.TextAlign = this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        }

        private void OcultarSubMenu_Clientes()
        {
            btnRegistrarCliente.Visible = false;
            btnConsultarClientes.Visible = false;
            btnInformesClientes.Visible = false;
            btnMailing.Visible = false;
            pnlRegresarClientes.Visible = false;
        }
        private void MostrarSubMenu_Ventas()
        {
            //MOSTRAR BOTONES SUB MENU
            btnRealizarVenta.Visible = true;
            btnRealizarVenta.Location = new Point(5, 74);

            btnRealizarVentaTactil.Visible = true;
            btnRealizarVentaTactil.Location = new Point(83, 74);

            btnInformesVentas.Visible = true;
            btnInformesVentas.Location = new Point(5, 133);

            btnEstadisticasVentas.Visible = true;
            btnEstadisticasVentas.Location = new Point(83, 133);

            btnParametrosVentas.Visible = true;
            btnParametrosVentas.Location = new Point(5, 192);

            pnlRegresarVentas.Visible = true;
            btnRegresarVentas.Visible = true;
            pnlRegresarVentas.Location = new Point(5, 317);

            //CAMBIAR TAMANO A CONTENEDOR SUBMENU
            btnVenta.Width = 154;
            botonTituloCambiar(btnVenta);
            PSupCambiarTamano();

            //OCULTAR MENU PRINCIPAL
            OcultarMenuPrincipal("Ventas");

        }
        private void OcultarSubMenu_Ventas()
        {
            btnRealizarVenta.Visible = false;
            btnRealizarVentaTactil.Visible = false;
            pnlRegresarVentas.Visible = false;
            btnRegresarVentas.Visible = false;
            btnInformesVentas.Visible = false;
            btnEstadisticasVentas.Visible = false;
            btnParametrosVentas.Visible = false;
        }
        private void MostrarMenuPrincipal()
        {
            //MOSTRAR MENU PRINCIPAL
            btnVenta.Visible = true;
            btnVenta.Location = new Point(5, 5);
            btnVenta.Width = 75;
            btnVenta.Height = 56;

            btnCliente.Visible = true;
            btnCliente.Location = new Point(83, 5);
            btnCliente.Width = 75;
            btnCliente.Height = 56;

            btnCompras.Visible = true;
            btnCompras.Location = new Point(5, 65);
            btnCompras.Width = 75;
            btnCompras.Height = 56;

            btnEmpleados.Visible = true;
            btnEmpleados.Location = new Point(83, 65);
            btnEmpleados.Width = 75;
            btnEmpleados.Height = 56;

            btnEscritorio.Visible = true;
            btnEscritorio.Location = new Point(43, 141);

            btnTraspasos.Visible = true;
            btnTraspasos.Location = new Point(5, 5);
            btnTraspasos.Width = 75;
            btnTraspasos.Height = 56;

            btnMercaderia.Visible = true;
            btnMercaderia.Location = new Point(83, 5);
            btnMercaderia.Width = 75;
            btnMercaderia.Height = 56;

            btnProduccion.Visible = true;
            btnProduccion.Location = new Point(5, 65);
            btnProduccion.Width = 75;
            btnProduccion.Height = 56;

            btnAlmacen.Visible = true;
            btnAlmacen.Location = new Point(83, 65);
            btnAlmacen.Width = 75;
            btnAlmacen.Height = 56;

            PInf.Visible = true;
            PInf.Location = new Point(5, 263);
            PInf.Width = 322;
            PInf.Height = 127;

            PSup.Visible = true;
            PSup.Location = new Point(5, 5);
            PSup.Width = 322;
            PSup.Height = 127;
        }

        private void OcultarMenuPrincipal(string visible)
        {
            int opcion = 0;
            Hashtable parametros = new Hashtable();

            parametros.Add("Clientes", 1);
            parametros.Add("Ventas", 2);
            parametros.Add("Compras", 3);
            parametros.Add("Empleados", 4);
            parametros.Add("Traspasos", 5);
            parametros.Add("Mercaderias", 6);
            parametros.Add("Produccion", 7);
            parametros.Add("Almacen", 8);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(visible))
                {
                    opcion = int.Parse(parametros[visible].ToString());
                }
                else
                {
                    opcion = -1;
                }
            }

            switch (opcion)
            {
                case 1:
                    btnVenta.Visible = false;
                    btnCliente.Visible = true;//Clientes ON
                    btnCompras.Visible = false;
                    btnEmpleados.Visible = false;
                    PInf.Visible = false;//PANEL INF OFF
                    btnEscritorio.Visible = false;
                    break;
                case 2:
                    btnVenta.Visible = true;//Ventas ON
                    btnCliente.Visible = false;
                    btnCompras.Visible = false;
                    btnEmpleados.Visible = false;
                    PInf.Visible = false;//PANEL INF OFF
                    btnEscritorio.Visible = false;
                    break;
                case 3:
                    btnVenta.Visible = false;
                    btnCliente.Visible = false;
                    btnCompras.Visible = true;//Compras ON
                    btnEmpleados.Visible = false;
                    PInf.Visible = false;//PANEL INF OFF
                    btnEscritorio.Visible = false;
                    break;
                case 4:
                    btnVenta.Visible = false;
                    btnCliente.Visible = false;
                    btnCompras.Visible = false;
                    btnEmpleados.Visible = true;//Empleados ON
                    PInf.Visible = false;//PANEL INF OFF
                    btnEscritorio.Visible = false;
                    break;
                case 5:
                    PSup.Visible = false; // PANEL SUP OFF                    
                    btnTraspasos.Visible = true; //TRASPASOS ON
                    btnMercaderia.Visible = false;
                    btnProduccion.Visible = false;
                    btnAlmacen.Visible = false;
                    btnEscritorio.Visible = false;
                    break;
                case 6:
                    PSup.Visible = false; // PANEL SUP OFF                    
                    btnTraspasos.Visible = false;
                    btnMercaderia.Visible = true;//MERCADERIA ON
                    btnProduccion.Visible = false;
                    btnAlmacen.Visible = false;
                    btnEscritorio.Visible = false;
                    break;
                case 7:
                    PSup.Visible = false; // PANEL SUP OFF                    
                    btnTraspasos.Visible = false;
                    btnMercaderia.Visible = false;
                    btnProduccion.Visible = true;//PRODUCCION ON
                    btnAlmacen.Visible = false;
                    btnEscritorio.Visible = false;
                    break;
                case 8:
                    PSup.Visible = false; // PANEL SUP OFF                    
                    btnTraspasos.Visible = false;
                    btnMercaderia.Visible = false;
                    btnProduccion.Visible = false;
                    btnAlmacen.Visible = true;//ALMACEN ON
                    btnEscritorio.Visible = false;
                    break;
            }



        }
        private void PSupCambiarTamano()
        {
            PSup.Height = 387;
            PSup.Width = 163;
            PSup.Location = new Point(5, 5);
        }
        private void PInfCambiarTamano()
        {
            PInf.Height = 387;
            PInf.Width = 163;
            PInf.Location = new Point(5, 5);
        }



        #endregion

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmPersonas x = new frmPersonas();
            x.lblTitulo.Text = ".: Clientes :.";
            x.param_tipoPersona = "C";
            x.Show();
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmPersonas x = new frmPersonas();
            x.lblTitulo.Text = ".: Empleados :.";
            x.param_tipoPersona = "E";
            x.Show();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MdiClient clienteMDI;

            foreach (Control control in this.Controls)
            {
                try
                {
                    clienteMDI = (MdiClient)control;
                    clienteMDI.BackColor = Color.FromArgb(51, 153, 255);
                    clienteMDI.MouseHover += new System.EventHandler(this.pnlEscritorio_MouseHover);
                }
                catch (InvalidCastException) { }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            u.Login = txtUsuario.Text;
            u.Clave = txtContraseña.Text;
            dt = mu.BuscarUsuario("Login", u);
            u.Modo = 0;
            u.IdUsuario = int.Parse(dt.Rows[0]["idUsuario"].ToString());
            mu.ActualizarRegistro_Usuario("Modo", u);
            dt2 = mu.BuscarUsuario("Login", u);

            //Registro de Accion de Usuario
            ma.Log("Usuarios", "Termino de Sesión", u.IdUsuario, u.IdUsuario);

            pnlMenu.Location = new Point(1300, 0);
            pnlMenu.Visible = false;
            CambioLogin_Principal();
        }

        private void CambioLogin_Principal() 
        {
            if (pnlMenu.Visible == false)
            {
                pnlLogin.Visible = true;
                pnlFH.Visible = true;
                pnlSalirSistema.Visible = true;

                txtContraseña.Text = null;
                txtUsuario.Text = null;

                txtFecha.Text = DateTime.Now.ToShortDateString();
                txtHora.Text = DateTime.Now.ToShortTimeString();

                pnlLogin.Location = new Point(this.ClientSize.Width / 2 - pnlLogin.Size.Width / 2, this.ClientSize.Height / 2 - pnlLogin.Size.Height / 2);
                pnlLogin.Anchor = AnchorStyles.None;
                
                pnlFH.Location = new Point(-65, 10);
            }
            else 
            {
                pnlMenu.Visible = true;
            }

        }

        //SUB MENUS
        private void btnRegistrarEmpleados_Click(object sender, EventArgs e)
        {
            frmPersonas x = new frmPersonas();
            x.lblTitulo.Text = ".: Empleados :.";
            x.param_tipoPersona = "E";
            x.accion_Ventana = "NUEVO";
            x.MdiParent = this;
            x.Show();
        }
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmPersonas x = new frmPersonas();
            x.lblTitulo.Text = ".: Clientes :.";
            x.param_tipoPersona = "C";
            x.accion_Ventana = "NUEVO";
            x.MdiParent = this;
            x.Show();
        }
        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            frmVentas x = new frmVentas();
            x.lblTitulo.Text = ".: Nueva Venta :.";
            x.param_tipoMovimiento = "E";
            x.MdiParent = this;
            x.Show();
        }
        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            frmPersonas x = new frmPersonas();
            x.lblTitulo.Text = ".: Clientes :.";
            x.param_tipoPersona = "C";
            x.accion_Ventana = "INICIO";
            x.MdiParent = this;
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.Login = txtUsuario.Text;
            u.Clave = txtContraseña.Text;
            dt = mu.BuscarUsuario("Login", u);
            if (dt.Rows[0]["Login"].ToString() == u.Login && dt.Rows[0]["Clave"].ToString() == u.Clave)
            {
                if (int.Parse(dt.Rows[0]["Modo"].ToString()) != 1)
                {
                    u.Modo = 1;
                    u.IdUsuario = int.Parse(dt.Rows[0]["idUsuario"].ToString());
                    mu.ActualizarRegistro_Usuario("Modo", u);
                    dt2 = mu.BuscarUsuario("Login", u);

                    //Mostrar Menu Principal
                    pnlMenu.Visible = true;
                    pnlLogin.Visible = false;
                    pnlFH.Visible = false;
                    pnlSalirSistema.Visible = false;
                    pnlMenu.Height = h;
                    pnlMenu.Width = 200;
                    pnlMenu.Location = new Point(w - 200, h - h);
                    this.Height = h;
                    this.Width = w;
                    MessageBox.Show("Ingreso Concedido");

                    //Registro de Accion de Usuario
                    ma.Log("Usuarios", "Inicio de Sesión", u.IdUsuario, u.IdUsuario);
                }
                else
                {
                    MessageBox.Show("Ya hay un usuario conectado a esa cuenta");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRealizarTraspasos_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenProduccion_Click(object sender, EventArgs e)
        {
            frmProducción x = new frmProducción();
            x.lblTitulo.Text = ".: Nueva Venta :.";
            //x.param_tipoMovimiento = "E";
            x.MdiParent = this;
            x.Show();
        }       
    }
}
