using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ventas_Milton.Vista
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox(string mensaje)
        {
            InitializeComponent();
            txtMensaje.Text = mensaje;
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
