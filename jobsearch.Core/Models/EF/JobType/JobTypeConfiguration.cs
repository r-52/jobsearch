namespace jobsearch.Core.Models.EF
{
    public class JobTypeConfiguration : IEntityTypeConfiguration<JobTypeEntity>
    {
        public void Configure(EntityTypeBuilder<JobTypeEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
                new { Id = 1, Revision = 0, CreatedAt = DateTime.UtcNow, Name = "jobtype.fulltime" },
                new { Id = 2, Revision = 0, CreatedAt = DateTime.UtcNow, Name = "jobtype.halfjob" },
                new { Id = 3, Revision = 0, CreatedAt = DateTime.UtcNow, Name = "jobtype.minijob" }
            );
        }
    }
}