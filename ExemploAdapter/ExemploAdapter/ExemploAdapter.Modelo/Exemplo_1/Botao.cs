using System;

namespace ExemploAdapter.Modelo.Exemplo_1
{
    public class Botao : IClicavel
    {
        public event EventHandler Clique;

        public void Clicar()
        {
            if (Clique != null)
                Clique.Invoke(this, new EventArgs());
        }
    }
}