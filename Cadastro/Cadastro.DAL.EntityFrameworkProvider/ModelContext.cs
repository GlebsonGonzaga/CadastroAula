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
        public DbSet<Telefone> Telefones { get; set; }

        public ModelContext(string connectionString) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //ADO.NET EF Team Blog: http://blogs.msdn.com/b/adonet/

            //Fluent API - Mapeamento: http://msdn.microsoft.com/en-us/data/jj591620.aspx

            //Mapeamento 1-To-M -> Fisica Has M Telefones
            modelBuilder.Entity<Pessoa>().HasMany(c => c.Telefones).WithOptional(f => f.Pessoa).WillCascadeOnDelete(true);

            modelBuilder.Entity<Fisica>().HasKey(c => c.Id).ToTable("Fisica");
            modelBuilder.Entity<Fisica>().Property(c => c.Id).HasColumnName("FisicaID");
            modelBuilder.Entity<Fisica>().Property(c => c.Nome).HasColumnName("Nome");
            

            //modelBuilder.Entity<Telefone>().HasKey(k => new {k.DDD, k.Numero});

            //modelBuilder.Entity<Category>().HasMany(c => c.Products).WithRequired(c => c.Category).Map(map => .MapKey("CategoryID"));

            //modelBuilder.Entity<Product>().HasKey(p => p.ID).ToTable("Products");
            //modelBuilder.Entity<Product>().Property(p => p.ID).HasColumnName("ProductID");
            //modelBuilder.Entity<Product>().Property(p => p.Nome).HasColumnName("ProductName");


            //Mapeamento M-To-M -> Category Has M Products & Produts has M Categories
            //modelBuilder.Entity<Category>().HasKey(c => c.ID).ToTable("Categories");
            //modelBuilder.Entity<Category>().Property(c => c.ID).HasColumnName("CategoryID");
            //modelBuilder.Entity<Category>().Property(c => c.Nome).HasColumnName("CategoryName");
            //modelBuilder.Entity<Category>().HasMany(c => c.Products).WithMany(p => p.Categories).Map(map => {
            //    map.MapLeftKey("CategoryID");
            //    map.MapRightKey("ProductID");
            //    map.ToTable("tblCategoryProduct");
            //});

            //modelBuilder.Entity<Product>().HasKey(p => p.ID).ToTable("Products");
            //modelBuilder.Entity<Product>().Property(p => p.ID).HasColumnName("ProductID");
            //modelBuilder.Entity<Product>().Property(p => p.Nome).HasColumnName("ProductName");

            base.OnModelCreating(modelBuilder);
        }
    }
}