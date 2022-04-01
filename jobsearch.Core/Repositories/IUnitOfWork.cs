namespace jobsearch.Core.Repositories
{
    public interface IUnitOfWork<out TContext>
         where TContext : class
    {
        Task<int> CommitAsync();
    }
}