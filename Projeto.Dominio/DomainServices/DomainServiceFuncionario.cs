using Projeto.Dominio.DomainContracts.Repositories;
using Projeto.Dominio.DomainContracts.Services;
using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.DomainServices
{
    public class DomainServiceFuncionario
        : DomainServiceBase<Funcionario, Int32>,
        IDomainServiceFuncionario
    {
        //atributo..
        private IRepositoryFuncionario repositorio;

        //construtor..
        public DomainServiceFuncionario(IRepositoryFuncionario repositorio)
            : base(repositorio)
        {
            this.repositorio = repositorio;
        }

    }
}
