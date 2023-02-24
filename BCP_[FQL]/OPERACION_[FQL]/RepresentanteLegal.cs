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
    public partial class RepresentanteLegal : Form
    {
        public RepresentanteLegal()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            CNDatos objeto = new CNDatos();
            grdViewDatos.DataSource = objeto.visualizarRepresentante();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarRepresentante registrar= new RegistrarRepresentante();
            registrar.Show();
        }
    }
}
