using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Model;

namespace Cadastro.DAL.EntityFrameworkProvider
{
    public class ModelContext : DbContext
    {
        public DbSet<Fisica> Fisicas { get; set; }

        public ModelContext(string connectionString) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasMany(c => c.Telefones).WithRequired(f => f.Pessoa).WillCascadeOnDelete(true);
            
            modelBuilder.Entity<Fisica>().HasKey(c => c.Id).ToTable("Fisica");
            modelBuilder.Entity<Fisica>().Property(c => c.Id).HasColumnName("Id");

            base.OnModelCreating(modelBuilder);
        }
    }
}

//ADO.NET EF Team Blog: http://blogs.msdn.com/b/adonet/
//Fluent API - Mapeamento: http://msdn.microsoft.com/en-us/data/jj591620.aspx