using System.Data.Entity;
using Cadastro.Model;

namespace Cadastro.DAL.EntityFrameworkProvider
{
    public class ModelContext : DbContext
    {
        public DbSet<Fisica> Fisicas { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        public ModelContext(string connectionString) : base(connectionString)
        {
            
        }
    }
}

//ADO.NET EF Team Blog: http://blogs.msdn.com/b/adonet/
//Fluent API - Mapeamento: http://msdn.microsoft.com/en-us/data/jj591620.aspx