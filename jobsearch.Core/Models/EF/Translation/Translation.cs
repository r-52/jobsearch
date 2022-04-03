namespace jobsearch.Core.Models.EF
{
    public class TranslationEntity : BaseKeyModel<int>
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public int LanguageId { get; set; }

        public LanguageEntity Language { get; set; }
    }
}