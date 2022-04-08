
namespace jobsearch.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataContext _context;

        #region repositories
        private JobRepository _jobRepository;
        public IJobRepository Jobs
        {
            get
            {
                if (_jobRepository is null)
                {
                    this._jobRepository = new JobRepository(this._context);
                }
                return this._jobRepository;
            }
        }
        #endregion

        public UnitOfWork(DataContext context)
        {
            this._context = context;
        }

        public async Task<int> CommitAsync()
        {
            var x = await this._context.SaveChangesAsync();
            return x;
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
