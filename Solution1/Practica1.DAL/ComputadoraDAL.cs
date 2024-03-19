using Practica1.MODELOS;
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
        public void InsertarComputadoraDAL(Computadora computadora)
        {
            string consulta = "insert into Computadora values('" + computadora.Nombre + "'," +
                                                          "'" + computadora.Descripcion + "'," +
                                                          "'" + computadora.Precio + "'," +
                                                          " '" + computadora.FechaFabricacion + "')";
            conexion.Ejecutar(consulta);
        }

        public Computadora ObtenerComputadoraIdDal(int id)
        {
            string consulta = "select * from computadora where idcomputadora=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Computadora c = new Computadora();
            if (tabla.Rows.Count > 0)
            {
                c.IdComputadora = Convert.ToInt32(tabla.Rows[0]["idcomputadora"]);
                c.Nombre = tabla.Rows[0]["nombre"].ToString();
                c.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                c.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
                c.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["fechafabricacion"]);
            }
            return c;

        }

        public void EditarComputadoraDal(Computadora computadora)
        {
            string consulta = "update computadora set nombre='" + computadora.Nombre + "'," +
                                                        "descripcion='" + computadora.Descripcion + "'," +
                                                        "precio='" + computadora.Precio + "'," +
                                                        "fechafabricacion='" + computadora.FechaFabricacion + "' " +
                                                        "where idcomputadora=" + computadora.IdComputadora;
            conexion.Ejecutar(consulta);
        }

        public void EliminarComputadoraDal(int id)
        {
            string consulta = "delete from computadora where idcomputadora=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
