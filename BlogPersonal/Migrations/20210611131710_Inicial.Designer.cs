﻿// <auto-generated />
using System;
using BlogPersonal.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPersonal.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210611131710_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("BlogPersonal.Models.Categoriaas", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Nombre = "Deportes"
                        },
                        new
                        {
                            CategoriaId = 2,
                            Nombre = "Tecnologia"
                        },
                        new
                        {
                            CategoriaId = 3,
                            Nombre = "Novedades"
                        },
                        new
                        {
                            CategoriaId = 4,
                            Nombre = "Salud"
                        },
                        new
                        {
                            CategoriaId = 5,
                            Nombre = "Politica"
                        });
                });

            modelBuilder.Entity("BlogPersonal.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contenido")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Resumen")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.ToTable("Post");
                });
#pragma warning restore 612, 618
        }
    }
}
