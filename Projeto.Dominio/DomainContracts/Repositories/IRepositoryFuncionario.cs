using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.DomainContracts.Repositories
{
    public interface IRepositoryFuncionario
        : IRepositoryBase<Funcionario, Int32>
    {

    }
}
