using Domain.Entities;
using MediatR;
using RepositoryEFCore.Repositories;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.Products
{
    public class GetProductQuery : IRequest<Product>
    {
        internal readonly Expression<Func<Product, bool>> Expression;        
        public GetProductQuery(Expression<Func<Product, bool>> expression)
        {
            Expression = expression;            
        }
    }

    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
    {
        readonly ProductRepository Repository;
        public GetProductQueryHandler(ProductRepository repository)
        {
            Repository = repository;
        }
        public Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            //Aquí lanzamos  las excepciones
            return Task.FromResult(Repository.RetrieveFirstOrDefault(request.Expression));
        }
    }
}
