namespace jobsearch.Core.Models.EF
{
    public class TagConfiguration : IEntityTypeConfiguration<TagEntity>
    {
        public void Configure(EntityTypeBuilder<TagEntity> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}