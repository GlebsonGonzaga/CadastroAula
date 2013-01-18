using System;

namespace ExemploAdapter.Modelo.Exemplo_1
{
    public class LampadaAdaptador
    {
        private IClicavel _clicavel;
        private IComutavel _comutavel;

        public LampadaAdaptador(IClicavel clicavel, IComutavel comutavel)
        {
            _clicavel = clicavel;
            _comutavel = comutavel;

            _clicavel.Clique += ClicavelClique;
        }

        void ClicavelClique(object sender, EventArgs e)
        {
            _comutavel.Comutar();
        }
    }
}