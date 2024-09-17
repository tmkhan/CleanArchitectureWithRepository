using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IRepository<T>//: IApplicationDbContext where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        Task<int> AddAsync(T entity);
        Task<int> SaveChangesAsync();
        Task<string> UpdateAsync(T entity);
        int Delete(T entity);
    }
}
