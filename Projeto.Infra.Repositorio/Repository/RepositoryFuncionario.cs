using Projeto.Dominio.DomainContracts.Repositories;
using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repositorio.Repository
{
    public class RepositoryFuncionario
        : RepositoryBase<Funcionario, Int32>,
        IRepositoryFuncionario
    {

    }
}
