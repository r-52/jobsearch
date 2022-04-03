namespace jobsearch.Core.Models.EF
{
    public class InstanceConfiguration : IEntityTypeConfiguration<InstanceEntity>
    {
        public void Configure(EntityTypeBuilder<InstanceEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(
                new { Id = 1, CreatedAt = DateTime.UtcNow, Revision = 1, Name = "Localhost", Domain = "localhost", Tld = "", MetaKeywords = "keywords", MetaDescription = "MetaDescription", ExtraCss = ".empty-class {}", LogoUrl = "", Imprint = "Test", LanguageId = 1 }
            );
        }
    }
}
