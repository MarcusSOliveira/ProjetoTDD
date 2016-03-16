using FluentNHibernate.Mapping;
using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repositorio.Mapping
{
    public class DepartamentoMap
        : ClassMap<Departamento>
    {
        public DepartamentoMap()
        {
            Table("DEPARTAMENTO"); //nome da tabela..

            //chave primaria..
            Id(d => d.IdDepartamento)
                .Column("IDDEPTO")
                .GeneratedBy.Identity();

            //demais propriedades..
            Map(d => d.Nome)
                .Column("NOME")
                .Length(50)
                .Not.Nullable();

            #region Relacionamentos

            HasMany(d => d.Funcionarios) //TEM Muitos Funcionarios
                .KeyColumn("IDDEPTO") //Chave estrangeira
                .Inverse(); //relacionamento inverso ao da classe Funcionario

            #endregion

        }
    }
}
