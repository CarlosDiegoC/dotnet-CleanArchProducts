using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchProducts.Domain.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetCategoriesAsync();
        Task<T> GetByIdAsync(int? id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }

    //Generic repository contract, created only to ilustrate.
}