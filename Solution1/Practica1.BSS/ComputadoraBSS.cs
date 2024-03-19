using Practica1.DAL;
using Practica1.MODELOS;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.BSS
{
    public class ComputadoraBSS
    {
        ComputadoraDAL dal = new ComputadoraDAL();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadoraDal();
        }

        public void InsertarComputadoraBss(Computadora computadora)
        {
            dal.InsertarComputadoraDAL(computadora);
        }

        public Computadora ObtenerComputadoraIdBss(int id)
        {
            return dal.ObtenerComputadoraIdDal(id);
        }
        public void EditarComputadoraBss(Computadora c)
        {
            dal.EditarComputadoraDal(c);
        }

        public void EliminarComputadoraBss(int id)
        {
            dal.EliminarComputadoraDal(id);
        }
    }
}
