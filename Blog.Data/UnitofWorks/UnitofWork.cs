using Blog.Data.Context;
using Blog.Data.Repositiries.Abstraction;
using Blog.Data.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.UnitofWorks
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext dbContext;
        public UnitofWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public AppDbContext DbContext { get; }

        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitofWork.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }
    }
}
