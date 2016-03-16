using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.DomainContracts.Services
{
    public interface IDomainServiceBase<T, K>
    {
        void Cadastrar(T obj);
        void Alterar(T obj);
        void Excluir(K id);
        List<T> ObterTodos();
        T ObterPorId(K id);
    }
}
