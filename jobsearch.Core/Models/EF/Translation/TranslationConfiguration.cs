namespace jobsearch.Core.Models.EF
{
    public class TranslationConfiguration : IEntityTypeConfiguration<TranslationEntity>
    {
        public void Configure(EntityTypeBuilder<TranslationEntity> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
