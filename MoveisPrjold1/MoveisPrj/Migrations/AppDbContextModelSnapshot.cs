﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoveisPrj.Context;

#nullable disable

namespace MoveisPrj.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("MoveisPrj.Models.Categoria", b =>
                {
                    b.Property<string>("CategoriaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("MoveisPrj.Models.Movel", b =>
                {
                    b.Property<int>("MovelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoriaId1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("MovelId");

                    b.HasIndex("CategoriaId1");

                    b.ToTable("Moveis");
                });

            modelBuilder.Entity("MoveisPrj.Models.Movel", b =>
                {
                    b.HasOne("MoveisPrj.Models.Categoria", "Categoria")
                        .WithMany("Moveis")
                        .HasForeignKey("CategoriaId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("MoveisPrj.Models.Categoria", b =>
                {
                    b.Navigation("Moveis");
                });
#pragma warning restore 612, 618
        }
    }
}
