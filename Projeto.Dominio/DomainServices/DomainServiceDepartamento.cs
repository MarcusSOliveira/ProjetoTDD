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
    public class DomainServiceDepartamento
        : DomainServiceBase<Departamento, Int32>, 
        IDomainServiceDepartamento
    {
        //atributo..
        private IRepositoryDepartamento repositorio;

        //construtor..
        public DomainServiceDepartamento(IRepositoryDepartamento repositorio)
            : base(repositorio)
        {
            this.repositorio = repositorio;
        }

    }
}
