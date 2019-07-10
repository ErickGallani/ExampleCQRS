namespace ExampleCQRS.Repository.Interfaces
{
    using System;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Entities;

    public interface IRepository<T>
        where T : Entity
    {
        Task<T> GetByIdAsync(Guid id);
        
        Task<int> AddAsync(T entity);
        
        Task<int> DeleteAsync(T entity);
        
        Task<int> EditAsync(T entity);
    }
}