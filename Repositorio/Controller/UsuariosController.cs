using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.DAO;
using Repositorio.Models;

namespace Repositorio.Controller
{
    public class UsuariosController
    {

        public void add(Usuarios model){
            UsuariosRepository dao = new UsuariosRepository();
            dao.inserir(model);
        }
        public IList<Usuarios> Listar()
        {
            UsuariosRepository dao = new UsuariosRepository();
            return dao.findAll();

        }
        public Usuarios retornaItemId(int id)
        {

            UsuariosRepository dao = new UsuariosRepository();
            return dao.findById(id);

        }

    }
}
