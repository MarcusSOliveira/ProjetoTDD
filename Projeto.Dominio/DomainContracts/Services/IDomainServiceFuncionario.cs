using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.DomainContracts.Services
{
    public interface IDomainServiceFuncionario
        : IDomainServiceBase<Funcionario, Int32>
    {

    }
}
