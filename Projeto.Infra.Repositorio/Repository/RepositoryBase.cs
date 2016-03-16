using Projeto.Dominio.DomainContracts.Repositories;
using Projeto.Infra.Repositorio.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq; //LAMBDA..

namespace Projeto.Infra.Repositorio.Repository
{
    public abstract class RepositoryBase<T, K>
        : IRepositoryBase<T, K>
    {
        public void Insert(T obj)
        {
            using (var s = HibernateUtil.Factory.OpenSession())
            {
                var t = s.BeginTransaction();
                s.Save(obj);
                t.Commit();
            }
        }

        public void Update(T obj)
        {
            using (var s = HibernateUtil.Factory.OpenSession())
            {
                var t = s.BeginTransaction();
                s.Update(obj);
                t.Commit();
            }
        }

        public void Delete(T obj)
        {
            using (var s = HibernateUtil.Factory.OpenSession())
            {
                var t = s.BeginTransaction();
                s.Delete(obj);
                t.Commit();
            }
        }

        public List<T> FindAll()
        {
            using (var s = HibernateUtil.Factory.OpenSession())
            {
                return s.Query<T>().ToList();
            }
        }

        public T FindById(K id)
        {
            using (var s = HibernateUtil.Factory.OpenSession())
            {
                return s.Get<T>(id);
            }
        }        
    }
}
