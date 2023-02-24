using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{

   public class CDRepresentateLegal
    {
        //Llamando a la Conexion
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();

        public void CrearRepresentante (string paterno, string materno, string nombres, string testimonio, string fechainicial, string fechafinal, string fechatestimonio, int numerotestimonio)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "SP_INSERTAR_REPRESENTANTE";
            comando.Parameters.AddWithValue("@PATERNO", paterno);
            comando.Parameters.AddWithValue("@MATERNO", materno);
            comando.Parameters.AddWithValue("@NOMBRES", nombres);
            comando.Parameters.AddWithValue("@TESTIMONIO", testimonio);
            comando.Parameters.AddWithValue("@FECHAINICIAL", fechainicial);
            comando.Parameters.AddWithValue("@FECHAFINAL", fechafinal);
            comando.Parameters.AddWithValue("@FECHATESTIMONIO", fechatestimonio);
            comando.Parameters.AddWithValue("@NUMERONOTARIA", numerotestimonio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
