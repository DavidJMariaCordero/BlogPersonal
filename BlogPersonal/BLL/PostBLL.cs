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
    public class PostBLL
    {
        public static bool Guardar(Post post)
        {
            if (!Existe(post.PostId))
                return Insertar(post);
            else
                return Modificar(post);
        }
        public static bool Insertar(Post post)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Post.Add(post);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Post.Any(p => p.PostId == id);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static bool Modificar(Post post)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(post).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool eliminado = false;
            Contexto contexto = new Contexto();

            try
            {
                var post = contexto.Post.Find(id);
                if (post != null)
                {
                    contexto.Post.Remove(post);
                    eliminado = contexto.SaveChanges() > 0;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return eliminado;
        }

        public static Post Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Post post;
            try
            {
                post = contexto.Post.Find(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return post;
        }

        public static List<Post> GetList(Expression<Func<Post, bool>> criterio)
        {
            List<Post> list = new List<Post>();
            Contexto context = new Contexto();

            try
            {
                list = context.Post.Where(criterio).AsNoTracking().ToList();
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
