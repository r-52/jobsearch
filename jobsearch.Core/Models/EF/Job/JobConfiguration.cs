namespace jobsearch.Core.Models.EF
{
    public class JobConfiguration : IEntityTypeConfiguration<JobEntity>
    {
        public void Configure(EntityTypeBuilder<JobEntity> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}