using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemploAdapter.Modelo.Exemplo_2;
using ExemploAdapter.Modelo.Interface;

namespace ExemploAdapter.Factory
{
    public class AdapterFactory
    {
        public static IClicavel GetClicavel(string contexto)
        {
            if (contexto == "Botao")
                return new BotaoAdapter();
            else
                return new LampadaClicavelAdapter();
        }
    }
}