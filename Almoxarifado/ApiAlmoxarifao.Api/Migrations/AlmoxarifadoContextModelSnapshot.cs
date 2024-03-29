﻿// <auto-generated />
using System;
using ApiAlmoxarifao.Api.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    [DbContext(typeof(AlmoxarifadoContext))]
    partial class AlmoxarifadoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Categoria", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cat_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatId"), 1L, 1);

                    b.Property<string>("CatDescricao")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("cat_descricao");

                    b.HasKey("CatId")
                        .HasName("PK__categori__DD5DDDBDCE421EB6");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Departamento", b =>
                {
                    b.Property<int>("DepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("dep_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepId"), 1L, 1);

                    b.Property<string>("DepDescricao")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("dep_descricao");

                    b.Property<bool?>("DepSituacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("dep_situacao")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("DepId")
                        .HasName("PK__departam__BB4BD8F84F7A2B81");

                    b.ToTable("departamento");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Funcionario", b =>
                {
                    b.Property<int>("FunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("fun_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FunId"), 1L, 1);

                    b.Property<string>("FunCargo")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("fun_cargo");

                    b.Property<string>("FunCidade")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("fun_cidade");

                    b.Property<string>("FunDataNacimento")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("fun_dataNacimento");

                    b.Property<string>("FunEndereco")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("fun_endereco");

                    b.Property<string>("FunNome")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("fun_nome");

                    b.Property<string>("FunSalario")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("fun_salario");

                    b.Property<string>("FunUf")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("fun_uf");

                    b.HasKey("FunId")
                        .HasName("PK__Funciona__35A47928D59F69CE");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.MotivoSaidum", b =>
                {
                    b.Property<int>("MotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("mot_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MotId"), 1L, 1);

                    b.Property<int?>("CatId")
                        .HasColumnType("int")
                        .HasColumnName("cat_id");

                    b.Property<string>("MotDescricao")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("mot_descricao");

                    b.HasKey("MotId")
                        .HasName("PK__MotivoSa__E0752241C9225504");

                    b.HasIndex("CatId");

                    b.ToTable("MotivoSaida");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Produto", b =>
                {
                    b.Property<int>("ProId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pro_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProId"), 1L, 1);

                    b.Property<int?>("CatId")
                        .HasColumnType("int")
                        .HasColumnName("cat_id");

                    b.Property<int?>("ProEstoque")
                        .HasColumnType("int")
                        .HasColumnName("pro_estoque");

                    b.Property<string>("ProImg")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("pro_img");

                    b.Property<string>("ProNome")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("pro_nome");

                    b.HasKey("ProId")
                        .HasName("PK__produtos__335E4CA6D5258034");

                    b.HasIndex("CatId");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Requisicao", b =>
                {
                    b.Property<int>("ReqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("req_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReqId"), 1L, 1);

                    b.Property<string>("ReqData")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("req_data");

                    b.Property<string>("ReqObservacao")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("req_observacao");

                    b.HasKey("ReqId")
                        .HasName("PK__requisic__1513A6FB0831AEEC");

                    b.ToTable("requisicao");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.MotivoSaidum", b =>
                {
                    b.HasOne("ApiAlmoxarifao.Api.Models.Categoria", "Cat")
                        .WithMany("MotivoSaida")
                        .HasForeignKey("CatId")
                        .HasConstraintName("FK__MotivoSai__cat_i__5CD6CB2B");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Produto", b =>
                {
                    b.HasOne("ApiAlmoxarifao.Api.Models.Categoria", "Cat")
                        .WithMany("Produtos")
                        .HasForeignKey("CatId")
                        .HasConstraintName("FK__produtos__cat_id__3A81B327");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Categoria", b =>
                {
                    b.Navigation("MotivoSaida");

                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
