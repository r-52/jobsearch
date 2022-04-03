namespace jobsearch.Core.Models.EF
{
    public class LanguageConfiguration : IEntityTypeConfiguration<LanguageEntity>
    {
        public void Configure(EntityTypeBuilder<LanguageEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(
                new { Id = 1, Name = "english", CreatedAt = DateTime.UtcNow },
                new { Id = 2, Name = "german", CreatedAt = DateTime.UtcNow }
            );
        }
    }
}
