using System;
using System.Collections.Generic;
using System.Linq;
using Cadastro.Model;

namespace Cadastro.DAL.EntityFrameworkProvider
{
    public class FisicaDao : IDAL<Fisica>
    {
        private readonly ModelContext _context = null;

        public FisicaDao(ModelContext context)
        {
            _context = context;
        }

        public List<Fisica> GetAll()
        {
            return _context.Fisicas.ToList();
        }

        public Fisica Get(Guid id)
        {
            return _context.Fisicas.FirstOrDefault(f => f.Id == id);
        }

        public void Insert(Fisica entity)
        {
            _context.Fisicas.Add(entity);
            SaveAll();
        }

        public void Delete(Fisica entity)
        {
            entity.Telefones.ForEach(t => _context.Telefones.Remove(t));
            _context.Fisicas.Remove(entity);
            SaveAll();
        }

        public void Update(Fisica entity)
        {
            SaveAll();
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }
    }
}