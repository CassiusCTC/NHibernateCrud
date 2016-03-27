using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.DAO;
using Repositorio.Models;

namespace Repositorio.Controller
{
    public class TiposController
    {
        public Tipos retornaItemId(int id) {

            TiposRepository dao = new TiposRepository();
            return dao.findById(id);
            
        }
        public IList<Tipos> Listar()
        {
            TiposRepository dao = new TiposRepository();
            return dao.findAll();

        }

    }
}
