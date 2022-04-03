namespace jobsearch.Core.Models.EF
{
    public class InstanceEntity : BaseModel<int>
    {
        public string Name { get; set; }

        public string Domain { get; set; }

        public string Tld { get; set; }

        public string? MetaKeywords { get; set; }

        public string? MetaDescription { get; set; }

        public string? ExtraCss { get; set; }

        public string? LogoUrl { get; set; }

        public string? Imprint { get; set; }

        public int LanguageId { get; set; }

        public LanguageEntity Language { get; set; }
    }
}