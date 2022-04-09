namespace jobsearch.Core.Models.EF
{
    public class TagEntity : BaseKeyModel<int>
    {
        public string TitleTranslationKey { get; set; }

        public string DescriptionTranslationKey { get; set; }

        public string Slug { get; set; }

        #region FK Instance
        public int InstanceId { get; set; }

        public InstanceEntity Instance { get; set; }
        #endregion

        public uint UsageCount { get; set; }
    }
}
