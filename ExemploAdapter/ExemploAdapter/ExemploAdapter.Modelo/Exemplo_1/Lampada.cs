namespace ExemploAdapter.Modelo.Exemplo_1
{
    public class Lampada : IComutavel
    {
        public bool Ligada { get; set; }

        public void Comutar()
        {
            Ligada = !Ligada;
        }
    }
}