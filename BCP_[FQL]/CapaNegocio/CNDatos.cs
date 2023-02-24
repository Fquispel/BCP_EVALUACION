using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CNDatos
    {
        private Datos cargar = new Datos();
        public DataTable visualizarData()
        {
            DataTable tabla = new DataTable();
            tabla = cargar.cargarDatos();
            return tabla;
        }
        public DataTable visualizarProveedor()
        {
            DataTable tabla = new DataTable();
            tabla = cargar.CargarProveedor();
            return tabla;
        }
        public DataTable visualizarRepresentante()
        {
            DataTable tabla = new DataTable();
            tabla = cargar.CargarRepresentante();
            return tabla;
        }
        public DataTable visualizarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = cargar.CargarUsuario();
            return tabla;
        }
    }
}
