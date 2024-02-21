using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EmprestimoDeLivros.API.Models;

namespace EmprestimoDeLivros.API.DAL
{
    public partial class ConexaoDB : DbContext
    {
        public ConexaoDB()
        {
        }

        public ConexaoDB(DbContextOptions<ConexaoDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Livro> Livros { get; set; } = null!;
        public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CliId)
                    .HasName("PK__Cliente__FFEFE14F03DA5485");
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.LivId)
                    .HasName("PK__Livros__1CAAB4B4B425E877");
            });

            modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
            {
                entity.HasKey(e => e.LceId)
                    .HasName("PK__LivroCli__C27BEFBF86BA4EC1");

                entity.HasOne(d => d.LceIdClienteNavigation)
                    .WithMany(p => p.LivroClienteEmprestimos)
                    .HasForeignKey(d => d.LceIdCliente)
                    .HasConstraintName("FK__LivroClie__lce_i__3B75D760");

                entity.HasOne(d => d.LceIdLivroNavigation)
                    .WithMany(p => p.LivroClienteEmprestimos)
                    .HasForeignKey(d => d.LceIdLivro)
                    .HasConstraintName("FK__LivroClie__lce_i__3C69FB99");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
