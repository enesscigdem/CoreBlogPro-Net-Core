using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using YoutubeBlog.Core.Entities;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repository.Abstractions;

namespace YoutubeBlog.Data.Repository.Concretes
{
    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private DbSet<T> Table { get => dbContext.Set<T>(); }

        // örneğin silinmemiş olan article'ları getirebilmek için func kullanımı yapıyoruz.
        // include isminde bir method var ve birbiri ile bağlı olan entityleri bize dönderme seçeneğini yapıyoruz bu yöntemle  ( includeProperties )
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate != null)
                query = query.Where(predicate);
            if (includeProperties.Any()) // içinde hiç değer var ise 
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.ToListAsync();
        }
        public async Task AddAsync(T entity)
        {
            //dbContext.Set<T>().Add(entity); // 18. satırdaki tanımlama yapılmasaydı bu şekilde çağrılması gerekecekti.
            await Table.AddAsync(entity);
        }

        // predicate null değil çünkü buraya kesinlikle 1 değer gelmeli.
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.SingleAsync();
        }

        public async Task<T> GetByGuidAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        //normalde update işlemi asenkron şeklinde gitmez. bir veriye bağlı olması gerekmektedir çünkü.
        public async Task<T> UpdateAsync(T entity)
        {
            // Yine de async bir yapı yapmak için Task.Run yaptık. ( Yapıyı bozmak istemediğimiz için kaçamak )
            await Task.Run(() => Table.Update(entity));
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate);
        }
    }
}