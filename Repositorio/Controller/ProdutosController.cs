using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.DAO;
using Repositorio.Models;

namespace Repositorio.Controller
{
    public class ProdutosController
    {

        public void add(Produtos model)
        {
            ProdutosRepository dao = new ProdutosRepository();
            dao.inserir(model);
        }
        public IList<Produtos> Listar()
        {
            ProdutosRepository dao = new ProdutosRepository();
            return dao.findAll();
           
        }

       
    }
}
