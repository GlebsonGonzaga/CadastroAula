using NUnit.Framework;

namespace ExemploAdapter.Modelo.Exemplo_1
{
    [TestFixture]
    public class LampadaTest
    {
        [Test]
        public void acender_e_apagar_a_lampada()
        {
            Botao botao = new Botao();
            Lampada lampada = new Lampada();
            LampadaAdaptador adaptador = new LampadaAdaptador(botao, lampada);

            botao.Clicar();
            Assert.That(lampada.Ligada);

            botao.Clicar();
            Assert.That(!lampada.Ligada);

            botao.Clicar();
            Assert.That(lampada.Ligada);

            botao.Clicar();
            Assert.That(!lampada.Ligada);
        }
    }
}