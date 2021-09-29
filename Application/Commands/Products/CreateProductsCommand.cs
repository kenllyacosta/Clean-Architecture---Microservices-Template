using Domain.Entities;
using MediatR;
using RepositoryEFCore.Repositories;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Products
{
    public class CreateProductsCommand : IRequest<bool>
    {
        internal readonly IEnumerable<Product> Products;
        public CreateProductsCommand(IEnumerable<Product> products)
        {
            Products = products;
        }
    }

    public class CreateProductsCommandHandler : IRequestHandler<CreateProductsCommand, bool>
    {
        private readonly ProductRepository Repository;
        public CreateProductsCommandHandler(ProductRepository repository)
        {
            Repository = repository;
        }

        public Task<bool> Handle(CreateProductsCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Repository.Create(request.Products));
        }
    }
}
