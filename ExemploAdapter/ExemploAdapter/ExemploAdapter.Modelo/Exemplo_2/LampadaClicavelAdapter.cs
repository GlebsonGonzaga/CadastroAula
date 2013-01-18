using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemploAdapter.Modelo.Interface;

namespace ExemploAdapter.Modelo.Exemplo_2
{
    public class LampadaClicavelAdapter : IClicavel
    {
        private readonly Lampada _lampada = new Lampada();
        public Lampada Lampada
        {
            get { return _lampada; }
        }

        public void Clique()
        {
            _lampada.Ligada = !_lampada.Ligada;
        }
    }
}