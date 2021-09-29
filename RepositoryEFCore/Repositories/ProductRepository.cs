using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryEFCore.Repositories
{
    public class ProductRepository : ICreate<Product>, IRetrieve<Product>
    {
        private readonly ApplicationDbContext Context;
        public ProductRepository(ApplicationDbContext context) => Context = context;

        public Product Create(Product entity)
        {
            var result = Context.Products.Add(entity);
            Context.SaveChanges();
            return result.Entity;
        }

        public bool Create(IEnumerable<Product> entities)
        {
            Context.Products.AddRange(entities);
            return Context.SaveChanges() != 0;
        }

        public IEnumerable<Product> Retrieve(Expression<Func<Product, bool>> predicate)
        {
            return Context.Products.Where(predicate);
        }

        public Product RetrieveFirstOrDefault(Expression<Func<Product, bool>> predicate)
        {
            return Context.Products.FirstOrDefault(predicate);
        }
    }
}
