using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.DAO
{ //T class generica 
    public interface InterfaceCrudDAO<T>
    {
        //insere um registro no banco de dados
        void inserir(T model);
        //altera um registro no banco de dados
        void alterar(T model);
        //exclui um registro no banco de dados
        void excluir(T model);
        //busca um registro pelo id no banco de dados
        T findById(int id);
        //retorna os registros da tabela registro no banco de dados
        IList<T> findAll();
        




    }
}
