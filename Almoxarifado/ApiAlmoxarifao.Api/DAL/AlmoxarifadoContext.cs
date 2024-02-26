using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.DAL
{
    public partial class AlmoxarifadoContext : DbContext
    {
        public AlmoxarifadoContext()
        {
        }

        public AlmoxarifadoContext(DbContextOptions<AlmoxarifadoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DataBase");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__categori__DD5DDDBDCE421EB6");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DepId)
                    .HasName("PK__departam__BB4BD8F8CB71FE79");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("PK__produtos__335E4CA6D5258034");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__produtos__cat_id__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
