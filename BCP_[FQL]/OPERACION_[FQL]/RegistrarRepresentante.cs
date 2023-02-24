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
    public partial class RegistrarRepresentante : Form
    {
        CNRegistrarRepresentante representante = new CNRegistrarRepresentante();
        private bool Editar = false;
        public RegistrarRepresentante()
        {
            InitializeComponent();
        }
        private void ClearControls()
        {
            TxtPaterno.Clear();            
            TxtMaterno.Clear();
            TxtNombre.Clear();
            TxtTestimonio.Clear();                        
            TxtNumTestimonio.Clear();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    //Validación de controles
                    if (TxtPaterno.Text == "")
                    {
                        MessageBox.Show("Ingrese el Apellido Paterno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtPaterno.Focus();
                        return;
                    }
                    if (TxtMaterno.Text == "")
                    {
                        MessageBox.Show("Ingrese el Apellido Materno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtMaterno.Focus();
                        return;
                    }

                    if (TxtNombre.Text == "")
                    {
                        MessageBox.Show("Ingrese el nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNombre.Focus();
                        return;
                    }                                       
                    if (TxtNumTestimonio.Text == "")
                    {
                        MessageBox.Show("Ingrese El Numero de Testimonio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNumTestimonio.Focus();
                        return;
                    }


                    representante.Create(TxtPaterno.Text, TxtMaterno.Text, TxtNombre.Text, TxtTestimonio.Text, DateInicio.Text, DateFin.Text, DateTestimonio.Text, Convert.ToInt32(TxtNumTestimonio.Text));
                    MessageBox.Show("Se guardo correctamente");
                    
                    ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos, se encontro el siguiente error : " + ex);
                }
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
