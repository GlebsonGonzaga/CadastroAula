using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Cadastro.Model
{
    public abstract class Pessoa
    {
        private List<Telefone> _telefones = new List<Telefone>(); 
        
        protected Pessoa() 
        {
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }

        public virtual List<Telefone> Telefones 
        {
            get 
            { 
                return _telefones; 
            }
            set { _telefones = value; }
        }

        public void AdicionarTelefone(int ddd, int numero)
        {
            //_telefones.Add(new Telefone() { Id = Guid.NewGuid(), DDD = ddd, Numero = numero });
            _telefones.Add(new Telefone() { Id = Guid.NewGuid(), Pessoa = this, DDD = ddd, Numero = numero });
        }
    }
}