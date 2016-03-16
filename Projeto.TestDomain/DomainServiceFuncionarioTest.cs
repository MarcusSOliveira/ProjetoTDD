using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Dominio.DomainContracts.Services;
using Projeto.Entidades;
using Projeto.Dominio.DomainServices;
using Projeto.Infra.Repositorio.Repository;

namespace Projeto.TestDomain
{
    [TestClass]
    public class DomainServiceFuncionarioTest
    {
        //atributo..
        private IDomainServiceFuncionario dominio;

        public DomainServiceFuncionarioTest()
        {
            dominio = new DomainServiceFuncionario(new RepositoryFuncionario());
        }

        [TestMethod]
        public void TestCadastroFuncionario()
        {
            try
            {
                Funcionario f = new Funcionario()
                {
                    Nome = "Funcionario Teste",
                    Salario = 1000M,
                    DataAdmissao = DateTime.Now,
                    Departamento = new Departamento()
                    {
                        IdDepartamento = 1
                    }
                };

                dominio.Cadastrar(f);

                //verificando se o id do funcionario foi gerado..
                Assert.IsTrue(f.IdFuncionario > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestAlteracaoFuncionario()
        {
            try
            {
                Funcionario f = new Funcionario()
                {
                    Nome = "Funcionario Teste",
                    Salario = 1000M,
                    DataAdmissao = DateTime.Now,
                    Departamento = new Departamento()
                    {
                        IdDepartamento = 1
                    }
                };

                dominio.Cadastrar(f); //gravando..
                //buscar pelo id..
                Funcionario registro = dominio.ObterPorId(f.IdFuncionario);

                //modificar os dados..
                registro.Nome = "Funcionario Teste Novo";
                registro.Salario = 3000M;

                //alterar..
                dominio.Alterar(registro);

                //buscar na base de dados..
                Funcionario fAlteracao = dominio.ObterPorId(registro.IdFuncionario);

                Assert.AreEqual(fAlteracao.Nome, registro.Nome);
                Assert.AreEqual(fAlteracao.Salario, registro.Salario);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestExclusaoFuncionario()
        {
            try
            {
                Funcionario f = new Funcionario()
                {
                    Nome = "Funcionario Teste",
                    Salario = 1000M,
                    DataAdmissao = DateTime.Now,
                    Departamento = new Departamento()
                    {
                        IdDepartamento = 1
                    }
                };

                dominio.Cadastrar(f); //gravando.
                dominio.Excluir(f.IdFuncionario); //excluindo..

                Assert.IsNull(dominio.ObterPorId(f.IdFuncionario));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }


        [TestMethod]
        public void TestObterFuncionario()
        {
            try
            {
                Funcionario f = new Funcionario()
                {
                    Nome = "Funcionario Teste",
                    Salario = 1000M,
                    DataAdmissao = DateTime.Now,
                    Departamento = new Departamento()
                    {
                        IdDepartamento = 1
                    }
                };

                dominio.Cadastrar(f); //gravando..
                //verificar se o funcionario foi encontrado pelo id..
                Assert.IsNotNull(dominio.ObterPorId(f.IdFuncionario));
            }
            catch(Exception e)
            {                
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestObterTodosFuncionario()
        {
            try
            {
                Assert.IsTrue(dominio.ObterTodos().Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

    }
}
