using FluentNHibernate.Mapping;
using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repositorio.Mapping
{
    public class FuncionarioMap
        : ClassMap<Funcionario>
    {
        public FuncionarioMap()
        {
            Table("FUNCIONARIO"); //tabela..

            //chave primaria..
            Id(f => f.IdFuncionario)
                .Column("IDFUNCIONARIO")
                .GeneratedBy.Identity();

            //demais propriedades..
            Map(f => f.Nome)
                .Column("NOME")
                .Length(50)
                .Not.Nullable();

            Map(f => f.Salario)
                .Column("SALARIO")
                .Precision(18)
                .Scale(2)
                .Not.Nullable();

            Map(f => f.DataAdmissao)
                .Column("DATAADMISSAO")
                .Not.Nullable();

            #region Relacionamentos

            References(f => f.Departamento) //TEM 1 Departamento
                .Column("IDDEPTO"); //Campo chave estrangeira na tabela..

            #endregion
        }
    }
}
