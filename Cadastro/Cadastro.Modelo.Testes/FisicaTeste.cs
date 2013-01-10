using System;
using System.Collections.Generic;
using System.Linq;
using Cadastro.Model;
using NUnit.Framework;

namespace Cadastro.Modelo.Testes
{
    [TestFixture]
    public class FisicaTeste
    {
        private readonly Guid id = Guid.Parse("{A691E98C-DE82-49CD-A26B-D5B8D8C5C30F}");

        [Test]
        public void a_criar_pessoa_fisica_utilizando_entity_framework()
        {
            VerificaSeEntidadeJaExiste();

            Fisica fisica = new Fisica();
            fisica.Id = id;
            fisica.Nome = @"Ubirajara Mendes Nunes Junior";
            fisica.Idade = 28;
            fisica.Sexo = "Masculino";
            fisica.AdicionarTelefone(21, 93901300);

            Factory.DaoFactory.GetFisicaDao().Insert(fisica);

            List<Fisica> fisicas = Factory.DaoFactory.GetFisicaDao().GetAll();
            
            Assert.That(fisicas.Contains(fisica));
        }

        private void VerificaSeEntidadeJaExiste()
        {
            Fisica fisica = Factory.DaoFactory.GetFisicaDao().GetAll().FirstOrDefault(p => p.Id == id);
            if (fisica != null)
                Factory.DaoFactory.GetFisicaDao().Delete(fisica);
        }

        [Test]
        public void b_buscar_pessoa_fisica_utilizando_entity_framework()
        {
            Fisica fisica = Factory.DaoFactory.GetFisicaDao().GetAll().FirstOrDefault(p => p.Id == id);
            Assert.That(fisica != null);
        }

        [Test]
        public void c_excluir_pessoa_fisica_utilizando_entity_framework()
        {
            Fisica fisica = Factory.DaoFactory.GetFisicaDao().GetAll().FirstOrDefault(p => p.Id == id);
            Factory.DaoFactory.GetFisicaDao().Delete(fisica);

            fisica = Factory.DaoFactory.GetFisicaDao().GetAll().FirstOrDefault(p => p.Id == id);

            Assert.That(fisica == null);
        }
    }
}