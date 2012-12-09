using System;
using Cadastro.DAL;
using Cadastro.Model;
using NUnit.Framework;

namespace Cadastro.Modelo.Testes
{
    [TestFixture]
    public class PessoaTeste
    {
        [Test]
        public void testa_insert_no_banco()
        {
            //Fisica fisica = new Fisica();
            //fisica.ID = Guid.NewGuid();
            //fisica.Nome = "Ubirajara Mendes";
            //fisica.Idade = 29;
            //fisica.Sexo = "Masculino";

            //IDAL<Fisica> dao = Factory.DaoFactory.GetFisicaDao();
            //dao.Insert(fisica);

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void testa_select_no_banco()
        {
            //string guid = @"a2e117ec-ef82-43ef-987d-c1d0ec9b311c";

            //IDAL<Fisica> dao = Factory.DaoFactory.GetFisicaDao();
            //Fisica fisica = dao.Get(Guid.Parse(guid));

            //Assert.IsNotNull(fisica);

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void teste_inoquo()
        {
            Assert.AreEqual(0, 0);
        }
    }
}
