using Application.Interfaces;
using Application.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Product.Queries
{
    public class GetAllProductsQuery:IRequest<IEnumerable<Domain.Entities.Product>>
    {

    }

    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery,IEnumerable<Domain.Entities.Product>>
    {
        private readonly IProductRepository _productRepository;
        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository=productRepository;
        }
        public async Task<IEnumerable<Domain.Entities.Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products=await _productRepository.GetAllAsync();
            return products;
            
        }
    }

    
}
