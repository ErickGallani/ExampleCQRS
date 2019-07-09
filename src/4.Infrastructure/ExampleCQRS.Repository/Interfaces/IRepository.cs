namespace ExampleCQRS.Repository.Interfaces
{
    using System;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Entities;

    public interface IRepository<T>
        where T : Entity
    {
        Task<T> GetByIdAsync(Guid id);
        
        Task AddAsync(T entity);
        
        Task DeleteAsync(T entity);
        
        Task EditAsync(T entity);
    }
}