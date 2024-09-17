using Application.Interfaces;
using Application.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Product.Commands
{
    public class UpdateProductCommand:IRequest<int>
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal rate { get; set; }
    }

    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository _repository;
        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _repository=productRepository;
        }
        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);

            if (product != null)
            {
               product.Id = request.Id;
                product.name = request.name;
                product.description = request.description;
                product.rate = request.rate;
                await _repository.SaveChangesAsync();
                return product.Id;
            }
            return default;

        }
    }
}
