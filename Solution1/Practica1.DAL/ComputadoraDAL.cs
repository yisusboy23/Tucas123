using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.DAL
{
    public class ComputadoraDAL
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = "select * from Computadora ";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

    }
}
