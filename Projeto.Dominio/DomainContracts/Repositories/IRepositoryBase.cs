using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.DomainContracts.Repositories
{
    public interface IRepositoryBase<T, K>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> FindAll();
        T FindById(K id);
    }
}
