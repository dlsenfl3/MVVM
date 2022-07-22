using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MVVM_Basics.DataBase;
using MVVM_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics.Services
{
    public class GenericDataService<T> : IDataService<T>
        where T : DomainObject
    {
        private readonly BasicDbContextFactory basicDbContextFactory;

        public GenericDataService(BasicDbContextFactory basicDbContextFactory)
        {
            this.basicDbContextFactory = basicDbContextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (BasicDbContext context = basicDbContextFactory.CreateDbContext())
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            };
        }

        public async Task<bool> Delete(int id)
        {
            using (BasicDbContext context = basicDbContextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            };
        }

        public async Task<T> Get(int id)
        {
            using (BasicDbContext context = basicDbContextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            };
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (BasicDbContext context = basicDbContextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            };
        }

        public async Task<T> Update(int id, T entity)
        {
            using (BasicDbContext context = basicDbContextFactory.CreateDbContext())
            {
                entity.Id = id;

                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            };
        }
    }
}
