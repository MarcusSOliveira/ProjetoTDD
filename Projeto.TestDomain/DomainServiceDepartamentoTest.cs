using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Dominio.DomainContracts.Services;
using Projeto.Entidades;
using Projeto.Dominio.DomainServices;
using Projeto.Infra.Repositorio.Repository;

namespace Projeto.TestDomain
{
    [TestClass]
    public class DomainServiceDepartamentoTest
    {
        //atributo..
        private IDomainServiceDepartamento dominio;

        public DomainServiceDepartamentoTest()
        {
            dominio = new DomainServiceDepartamento(new RepositoryDepartamento());
        }

        [TestMethod]
        public void TestCadastroDepartamento()
        {
            try
            {
                Departamento d = new Departamento()
                {
                    Nome = "Departamento Teste"
                };

                dominio.Cadastrar(d);                
                Assert.IsTrue(d.IdDepartamento > 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestAlteracaoDepartamento()
        {
            try
            {
                Departamento d = new Departamento()
                {
                    Nome = "Departamento Teste"
                };

                dominio.Cadastrar(d); //gravando..
                //buscar pelo id..
                Departamento registro = dominio.ObterPorId(d.IdDepartamento);

                //modificar os dados..
                registro.Nome = "Departamento Teste Novo";

                //alterar..
                dominio.Alterar(registro);

                //buscar na base de dados..
                Departamento fAlteracao = dominio.ObterPorId(registro.IdDepartamento);
                Assert.AreEqual(fAlteracao.Nome, registro.Nome);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestExclusaoDepartamento()
        {
            try
            {
                Departamento d = new Departamento()
                {
                    Nome = "Departamento Teste"
                };

                dominio.Cadastrar(d); //gravando.
                dominio.Excluir(d.IdDepartamento); //excluindo..

                Assert.IsNull(dominio.ObterPorId(d.IdDepartamento));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }


        [TestMethod]
        public void TestObterDepartamento()
        {
            try
            {
                Departamento d = new Departamento()
                {
                    Nome = "Departamento Teste"
                };

                dominio.Cadastrar(d); //gravando..
                //verificar se o funcionario foi encontrado pelo id..
                Assert.IsNotNull(dominio.ObterPorId(d.IdDepartamento));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestObterTodosDepartamento()
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
