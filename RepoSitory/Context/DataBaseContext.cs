using System;
using Microsoft.EntityFrameworkCore;
using WebApi_Estoque.Model;

namespace WebApi_Estoque.RepoSitory.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Cliente>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

        }

    }
}

