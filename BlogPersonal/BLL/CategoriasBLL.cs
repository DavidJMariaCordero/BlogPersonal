using BlogPersonal.DAL;
using BlogPersonal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlogPersonal.BLL
{
    public class CategoriasBLL
    {

        public static Categoriaas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Categoriaas categoria;
            try
            {
                categoria = contexto.Categorias.Find(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return categoria;
        }

        public static List<Categoriaas> GetList(Expression<Func<Categoriaas, bool>> criterio)
        {
            List<Categoriaas> list = new List<Categoriaas>();
            Contexto context = new Contexto();

            try
            {
                list = context.Categorias.Where(criterio).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return list;
        }
    }
}
