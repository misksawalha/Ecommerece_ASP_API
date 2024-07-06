using Ecommerce.Core.Entities;
using Ecommerce.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructer.Repositories
{
    public class ProductRepository : GenericRepository<Products>,IProductRepository
    {
        private readonly ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }
      /*  public void CreateProduct(Products model)
        {
            var product = context.Products.Add(model);
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
            
        }

        public Products GetProductById(int id)
        {
            var products = context.Products.Find(id);
            return products;
        }

        public IEnumerable<Products> GetProducts()
        {
            var products = context.Products;
            return products;
        }

        public void UpdateProduct(Products model)
        {
            context.Products.Update(model);
            context.SaveChanges();
        }
      */
    }
}
