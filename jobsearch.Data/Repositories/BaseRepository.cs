using System.Linq.Expressions;

namespace jobsearch.Data
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class
    {
        internal DataContext _context;

        internal DbSet<TEntity> _dbSet;


        public BaseRepository(DataContext ctxt)
        {
            this._context = ctxt;
            this._dbSet = ctxt.Set<TEntity>();
        }

        public virtual async Task<bool> DeleteAsync(TKey id)
        {
            var elem = await this.GetByIdAsync(id);
            if (elem is null)
            {
                return false;
            }
            this._dbSet.Remove(elem);
            return true;
        }

        public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var x = await this._dbSet.Where(predicate).ToListAsync();
            return x;
        }

        public async virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var x = await this._dbSet.ToListAsync();
            return x;
        }

        public async virtual Task<TEntity> GetByIdAsync(TKey id)
        {
            var x = await this._dbSet.FindAsync(id);
            return x;
        }

        public async virtual Task<bool> InsertAsync(TEntity entity)
        {
            var x = await this._dbSet.AddAsync(entity);
            return x != null;
        }
    }
}
