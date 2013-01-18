using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemploAdapter.Modelo.Interface;
using NUnit.Framework;

namespace ExemploAdapter.Test
{
    [TestFixture]
    public class ExemploAdapterTest
    {
        [Test]
        [ExpectedException(UserMessage = "BotaoClicado")]
        public void testar_clique()
        {
            IClicavel clicavel = Factory.AdapterFactory.GetClicavel("Botao");
            clicavel.Clique();
        }
    }
}