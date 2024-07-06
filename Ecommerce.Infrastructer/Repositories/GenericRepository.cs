using Ecommerce.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context) {
            this.context = context;
        }


        void IGenericRepository<T>.Create(T model)
        {
            context.Set<T>().Add(model);
            context.SaveChanges();
        }

        void IGenericRepository<T>.Delete(int id)
        {
            context.Remove(id);
            context.SaveChanges();
        }

        IEnumerable<T> IGenericRepository<T>.GetAll()
        {
          return  context.Set<T>().ToList();
        }

        T IGenericRepository<T>.GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        void IGenericRepository<T>.Update(T model)
        {
            context.Set<T>().Update(model);
        }
    }

}
