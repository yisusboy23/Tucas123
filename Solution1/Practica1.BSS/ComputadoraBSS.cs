using Practica1.DAL;
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
    }
}
