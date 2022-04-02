namespace jobsearch.Core.Models.EF
{
    public class TagUsageConfiguration : IEntityTypeConfiguration<TagUsageEntity>
    {
        public void Configure(EntityTypeBuilder<TagUsageEntity> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}