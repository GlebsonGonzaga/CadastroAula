using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemploAdapter.Modelo.Interface;

namespace ExemploAdapter.Modelo.Exemplo_2
{
    public class BotaoAdapter : IClicavel
    {
        readonly Botao _botao = new Botao();
        public Botao Botao
        {
            get { return _botao; }
        }

        public void Clique()
        {
            _botao.Clique();
        }
    }
}