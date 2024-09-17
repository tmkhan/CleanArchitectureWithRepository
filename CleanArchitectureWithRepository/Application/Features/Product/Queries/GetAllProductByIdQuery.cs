using Application.Interfaces;
using Application.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Product.Queries
{
    public class GetProductByIdQuery:IRequest<Domain.Entities.Product>
    {
        public int Id { get; set; }
    }

    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Domain.Entities.Product>
    {
        private readonly IProductRepository _repository;
        public GetProductByIdHandler(IProductRepository productRepository)
        {
            _repository=productRepository;
        }
        public async Task<Domain.Entities.Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result=await _repository.GetByIdAsync(request.Id);
            return result;
            
        }
    }

    
}
