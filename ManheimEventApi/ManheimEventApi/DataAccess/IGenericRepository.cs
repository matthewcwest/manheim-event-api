using System.Threading.Tasks;

namespace ManheimEventApi.DataAccess
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void AddOrUpdate(TEntity entityToUpdate);

        Task SaveChangesAsync();
    }
}
