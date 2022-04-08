namespace jobsearch.Data.Repositories {
    public class JobRepository : BaseRepository<JobEntity, int>, IJobRepository
    {
        public JobRepository(DataContext ctxt) : base(ctxt)
        {
        }
    }
}
