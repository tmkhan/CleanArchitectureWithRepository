using Application.Interfaces;
using Application.Interfaces.Repositories;
using Azure.Core;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IApplicationDbContext _context;
        public ProductRepository(IApplicationDbContext applicationDbContext)
        {
                _context = applicationDbContext;
        }
        public DbSet<Product> Product { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task<int> AddAsync(Product entity)
        {
            await _context.Product.AddAsync(entity);
            return entity.Id;
        }

        public int Delete(Product entity)
        {
              _context.Product.Remove(entity);
            return entity.Id;
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            return await _context.Product.ToListAsync();
        }
        

        public async Task<Product> GetByIdAsync(long id)
        {
            return await _context.Product.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public Task<string> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
