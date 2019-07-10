namespace ExampleCQRS.Repository.Repositories
{
    using System;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Entities;
    using ExampleCQRS.Repository.Context;
    using ExampleCQRS.Repository.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public abstract class Repository<T> : IRepository<T>
        where T : Entity
    {
        protected readonly CQRSContext context;

        public Repository(CQRSContext context)
        {
            this.context = context;
        }

        public async Task<int> InsertAsync(T entity)
        {
            context.Set<T>().Add(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return await context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(Guid id) => 
            await context.Set<T>().FindAsync(id);
    }
}