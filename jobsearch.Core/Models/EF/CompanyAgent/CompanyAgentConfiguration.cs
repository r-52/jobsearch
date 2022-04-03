namespace jobsearch.Core.Models.EF
{
    public class CompanyAgentConfiguration : IEntityTypeConfiguration<CompanyAgentEntity>
    {
        public void Configure(EntityTypeBuilder<CompanyAgentEntity> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
