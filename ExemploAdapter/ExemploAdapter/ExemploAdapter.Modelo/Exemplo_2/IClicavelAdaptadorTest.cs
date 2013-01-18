using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemploAdapter.Modelo.Interface;
using NUnit.Framework;

namespace ExemploAdapter.Modelo.Exemplo_2
{
    [TestFixture]
    public class IClicavelAdaptadorTest
    {
        [Test]
        [ExpectedException(UserMessage = "BotaoClicado")]
        public void clique_no_botao()
        {
            IClicavel botao = new BotaoAdapter();
            botao.Clique();
        }

        [Test]
        public void acender_e_apagar_a_lampada()
        {
            IClicavel lampada = new LampadaClicavelAdapter();
            

            lampada.Clique();
            Assert.That(((LampadaClicavelAdapter)lampada).Lampada.Ligada);

            lampada.Clique();
            Assert.That(!((LampadaClicavelAdapter)lampada).Lampada.Ligada);

            lampada.Clique();
            Assert.That(((LampadaClicavelAdapter)lampada).Lampada.Ligada);

            lampada.Clique();
            Assert.That(!((LampadaClicavelAdapter)lampada).Lampada.Ligada);
        }

    }
}
