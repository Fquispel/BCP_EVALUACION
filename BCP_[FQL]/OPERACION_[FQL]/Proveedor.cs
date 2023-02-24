using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
namespace OPERACION__FQL_
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void grdViewDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            CNDatos objeto = new CNDatos();
            grdViewDatos.DataSource = objeto.visualizarProveedor();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
