using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Entidades;
using Ventas_Milton.Datos;
using Ventas_Milton.Manejadores;
using System.Collections;

namespace Ventas_Milton.Vista
{
    public partial class frmProducción : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        funciones funciones = new funciones();
        Manejador_Categorias mc = new Manejador_Categorias();
        Manejador_Mercaderia mm = new Manejador_Mercaderia();
        static DataTable dt = new DataTable();
        ArrayList cods = new ArrayList();
        

        public frmProducción()
        {
            InitializeComponent();
            cargarDatosPrevios();
            //dgrSeleccionProductos.
        }

        private void dgvProdcutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            frmProducción_MouseMove(sender, e);
        }
        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            frmProducción_MouseDown(sender, e);
        }
        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            frmProducción_MouseUp(sender, e);
        }
        private void frmProducción_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void frmProducción_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void frmProducción_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void cargarDatosPrevios()
        {
            csCategorias cat = new csCategorias();
            funciones.CargarComboBox(mc.BuscarCategoria("Todos", cat), cmbCategoria, 1);            
        }

        private void cmbTipoProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            csMercaderia m = new csMercaderia();
            int index = cmbCategoria.SelectedIndex + 1;
            m.CodCategoria = index;
            funciones.CargarDataGrid(mm.BuscarMercaderia("Categoria", m), dgrSeleccionProductos);
            dgrSeleccionProductos.Columns["Seleccionar"].DisplayIndex = 4;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgrSeleccionProductos.Rows.Count; i++) 
            {
                bool seleccionado;
                if (dgrSeleccionProductos.Rows[i].Cells["Seleccionar"].Value == null)
                {
                    seleccionado = false;
                }
                else 
                {
                    seleccionado = true;
                }
                
                if(seleccionado == true)
                {
                    int codigo = int.Parse(dgrSeleccionProductos.Rows[i].Cells["CodProducto"].Value.ToString());
                    cods.Add(codigo);
                    MessageBox.Show("Codigo de Producto en Posicion [" + i + "] es => " + cods[i]);
                }
            }
            cargarDatosMercaderiaProduccion(cods);
            cods.Clear();
        }

        void cargarDatosMercaderiaProduccion(ArrayList array) 
        {
            for (int i = 0; i < array.Count; i++) 
            {
                csMercaderia m = new csMercaderia();
                m.IdMercaderia = int.Parse(array[i].ToString());
                dt = mm.BuscarMercaderia("AProduccion", m);
                if (dt.Rows.Count != 0)
                {
                    string cod = dt.Rows[0]["Codigo"].ToString();
                    string Mercaderia = dt.Rows[0]["Mercaderia"].ToString();
                    string categoria = dt.Rows[0]["Categoria"].ToString();

                    string[] row = new string[] { cod, Mercaderia, categoria };
                    dgrProductosProduccion.Rows.Add(row);
                }
                else 
                {
                    MessageBox.Show("ERROR CARGANDO DATOS");
                }                
            }            
        }

        private void btnProducir_Click(object sender, EventArgs e)
        {


            #region //Revisar            
            //ArrayList Z = new ArrayList();
            //ArrayList factoresPrimos = new ArrayList();
            //ArrayList mcd = new ArrayList();
            //ArrayList p = new ArrayList();
            //ArrayList sobras = new ArrayList();
            
            //int divisor, var,X,Y,Zn,sobra,menor=0;
            ////int factorPrimo = 0;

            //#region//Obteniendo los valores de Zn = Cantidad de paquetes posibles en base al N° de productos seleccionados.
            //for (int i = 0; i < dgrProductosProduccion.Rows.Count; i++) 
            //{
            //    divisor = 2;
            //    Y = int.Parse(dgrProductosProduccion.Rows[i].Cells["CntAUsar"].Value.ToString());
            //    X = int.Parse(dgrProductosProduccion.Rows[i].Cells["CantXPaq"].Value.ToString());
            //    sobra = Y % divisor;
            //    sobras.Add((object)sobra);
            //    Zn = (Y - sobra) / divisor;
            //    Z.Add((object)Zn);
            //}
            //#endregion
            
            //#region//Obteniendo el número Zn Menor
            //for (int i = 0; i < Z.Count; i++)
            //{
            //    int num1 = int.Parse(Z[0].ToString());
            //    int num2 = int.Parse(Z[i+1].ToString());
            //    for (int j = 0; j < Z.Count; j++) 
            //    {
            //        if (num1 <= num2)
            //        {
            //            menor = num1;
            //        }
            //        else 
            //        {
            //            menor = num2;
            //            num1 = menor;
            //        }
            //    }
            //}
            //#endregion

            //#region//Obteniendo los divisores del Zn Menor
            //ArrayList divisoresZn = new ArrayList();
            //for (int i = 0; i <= menor; i++) 
            //{
            //    if (menor % i == 0) 
            //    {
            //        divisoresZn.Add((object)i);
            //    }
            //}
            //#endregion

            //#region//Obteniendo los MCD de los valores Z
            //Hashtable MCD = new Hashtable();
            //bool divAceptado = false;
            //int divisorZn = 0;
            //for (int i = 0; i < Z.Count; i++) 
            //{
            //    int num1 = int.Parse(Z[i].ToString());
            //    for (int j = 0; j < divisoresZn.Count; j++) 
            //    {
            //        divisorZn = int.Parse(divisoresZn[j].ToString());

            //        if (num1 % divisorZn == 0) 
            //        {
            //            divAceptado = true;                                                
            //        }
            //        MCD.Add(divisorZn, divAceptado);
            //    }
            //}

            ////for (int i = 0; i < divisoresZn.Count; i++) 
            ////{
            ////    int div = int.Parse(divisoresZn[i].ToString());
            ////    int MCDFinal;
            ////    if (MCD[div].Equals(true)) 
            ////    {
            ////        ICollection claves = MCD.Keys;
            ////        foreach (string s in claves)
            ////        {

            ////        }
            ////        //MCDFinal = 
            ////    }
            ////}
            //#endregion
            #endregion
        }
    }
}
