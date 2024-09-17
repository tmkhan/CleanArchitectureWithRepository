using Application.Interfaces;
using Application.Interfaces.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Commands
{
    public class DeleteProductCommand:IRequest<int>
    {
        public int Id { get; set; }
    }

    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, int>
    {        
        private readonly IProductRepository _repository;
        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _repository = productRepository;
        }
        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product=await _repository.GetByIdAsync(request.Id);

            if (product != null)
            {
               _repository.Delete(product);
                await _repository.SaveChangesAsync();
                return product.Id;
            }
            return default;

        }
    }
}
