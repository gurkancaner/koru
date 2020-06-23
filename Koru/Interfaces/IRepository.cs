using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository
    {
        Task<T> GetByIdAsync<T>(long Id);
        Task<T> GetByNameAsync<T>(string name);
        Task<T> ListAsync<T>();

        Task<T> AddAsync<T>(T entity);
        Task UpdateAsync<T>(T entity);
        Task DeleteAsync<T>(T entity);
    }
}
