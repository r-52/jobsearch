namespace jobsearch.Core.Models.EF
{
    public class JobTypeEntity : BaseModel<int>
    {
        private ILazyLoader _lazyLoader;

        public string Name { get; set; }

        private List<JobEntity> _jobs;

        public List<JobEntity> jobs => this._lazyLoader.Load(this, ref this._jobs);

        public JobTypeEntity()
        {
            
        }

        private JobTypeEntity(ILazyLoader lazyLoader)
        {
            this._lazyLoader = lazyLoader;
        }
    }
}