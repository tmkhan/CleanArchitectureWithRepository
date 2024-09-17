using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //public DbSet<Product> Product { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<string> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IRepository<T>.AddAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
