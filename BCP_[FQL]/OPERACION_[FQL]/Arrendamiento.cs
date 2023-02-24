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
    public partial class Arrendamiento : Form
    {
        public Arrendamiento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            CNDatos objeto = new CNDatos();
            grdViewDatos.DataSource = objeto.visualizarData();

        }
    }
}
