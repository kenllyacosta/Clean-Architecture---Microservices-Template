using Domain.Entities;
using MediatR;
using RepositoryEFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.Products
{
    public class GetProductsQuery : IRequest<List<Product>>
    {
        internal readonly Expression<Func<Product, bool>> Expression;        
        public GetProductsQuery(Expression<Func<Product, bool>> expression)
        {
            Expression = expression;            
        }
    }

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<Product>>
    {
        readonly ProductRepository Repository;
        public GetProductsQueryHandler(ProductRepository repository)
        {
            Repository = repository;
        }

        public Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            //Aquí lanzamos  las excepciones
            return Task.FromResult(Repository.Retrieve(request.Expression).ToList());
        }
    }
}
