using BlogPersonal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPersonal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Post> Post { get; set; }
        public DbSet<Categoriaas> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=Data\Post.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoriaas>().HasData(new Categoriaas
            {
                CategoriaId = 1,
                Nombre = "Deportes",
                
            }, 
            new Categoriaas
            {
                CategoriaId = 2,
                Nombre = "Tecnologia"
            },
            new Categoriaas
            {
                CategoriaId = 3,
                Nombre = "Novedades"
            },
            new Categoriaas
            {
                CategoriaId = 4,
                Nombre = "Salud"
            },
            new Categoriaas
            {
                CategoriaId = 5,
                Nombre = "Politica"
            });
        }

    }
}
