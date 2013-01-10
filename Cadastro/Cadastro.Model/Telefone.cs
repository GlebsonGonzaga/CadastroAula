using System;

namespace Cadastro.Model
{
    public class Telefone
    {
        public Guid Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
    }
}