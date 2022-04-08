namespace jobsearch.Core.Repositories
{
    public interface IBaseRepository<TEntity, TKey> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(TKey id);

        Task<bool> InsertAsync(TEntity entity);

        Task<bool> DeleteAsync(TKey id);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
