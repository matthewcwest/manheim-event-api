using ManheimEventApi.Logging;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ManheimEventApi.DataAccess
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>, IDisposable where TEntity : class
    {
        private bool hasRetried = false;

        private readonly DbContext dbContext;

        private TEntity entity;

        internal DbSet<TEntity> dbSet;

        public GenericRepository()
        {
            dbContext = new DbContext();
            dbSet = dbContext.Set<TEntity>();
        }

        public void AddOrUpdate(TEntity entity)
        {
            this.entity = entity;

            dbSet.AddOrUpdate(entity);
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException.InnerException as SqlException;

                if (ShouldRetry(innerException))
                {
                    hasRetried = true;

                    Logger.Warning(innerException.Message);
                    Logger.Warning($"Now attempting to update");

                    Update(entity);

                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    Logger.Error($"Class: {nameof(GenericRepository<TEntity>)}, Method: {nameof(AddOrUpdate)}");
                    Logger.Error(ex);
                    throw;
                }

            }
        }

        private void Update(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        private bool ShouldRetry(SqlException innerException)
        {
            return innerException != null && innerException.Number == 2627 && !hasRetried;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                    dbSet = null;
                    entity = null;
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}