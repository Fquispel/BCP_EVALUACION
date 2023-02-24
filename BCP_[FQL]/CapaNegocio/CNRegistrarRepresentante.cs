using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CNRegistrarRepresentante
    {
        private CDRepresentateLegal crear = new CDRepresentateLegal();

        public void Create (string paterno, string materno, string nombres, string testimonio, string fechainicial, string fechafinal, string fechatestimonio, int numerotestimonio)
        {            
            crear.CrearRepresentante (paterno, materno, nombres, testimonio,fechainicial,  fechafinal,  fechatestimonio, numerotestimonio);
            
        }
    }
}
