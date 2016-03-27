using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Repositorio.FactoryConnection;

namespace Repositorio.DAO
{
    // Estou extendendo a interface InterfaceCrudDAO, e dizendo na clasula where que T tem que ser obrigatoriamente uma classe.
    public class RepositorioCrudDAO<T> : InterfaceCrudDAO<T> where T : class
    {
        public void alterar(T model)
        {
            using (ISession session = FluentSessionFactory.OpenSession())
            {

                using (ITransaction transacao = session.BeginTransaction())
                {

                    try
                    {
                        session.Update(model);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao alterar registro: " + ex.Message);
                    }
                }

            }
        }

        public void excluir(T model)
        {
            using (ISession session = FluentSessionFactory.OpenSession())
            {

                using (ITransaction transacao = session.BeginTransaction())
                {

                    try
                    {
                        session.Delete(model);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao  excluir registro: " + ex.Message);
                    }
                }

            }
        }

        public IList<T> findAll()
        {
            using (ISession session = FluentSessionFactory.OpenSession())
            {

                return (from e in session.Query<T>() select e).ToList();

            }
        }

        public T findById(int id)
        {
            using (ISession session = FluentSessionFactory.OpenSession())
            {

                return session.Get<T>(id);

            }
        }

        public void inserir(T model)
        {
            using (ISession session= FluentSessionFactory.OpenSession()) {

                using (ITransaction transacao = session.BeginTransaction()) {

                    try
                    {
                        session.Save(model);
                        transacao.Commit();
                    }
                    catch(Exception ex) {
                        if (!transacao.WasCommitted) {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao inserir registro: " + ex.Message);
                    }
                }

            }
        }
    }
  
}
