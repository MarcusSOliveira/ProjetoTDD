using Projeto.Dominio.DomainContracts.Repositories;
using Projeto.Dominio.DomainContracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.DomainServices
{
    public abstract class DomainServiceBase<T, K>
        : IDomainServiceBase<T, K>
    {
        //atributo..
        private IRepositoryBase<T, K> repositorio;

        //construtor..
        public DomainServiceBase(IRepositoryBase<T, K> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Cadastrar(T obj)
        {
            repositorio.Insert(obj);
        }

        public void Alterar(T obj)
        {
            repositorio.Update(obj);
        }        

        public void Excluir(K id)
        {
            T obj = repositorio.FindById(id);
            repositorio.Delete(obj);
        }

        public T ObterPorId(K id)
        {
            return repositorio.FindById(id);
        }

        public List<T> ObterTodos()
        {
            return repositorio.FindAll();
        }
    }
}
