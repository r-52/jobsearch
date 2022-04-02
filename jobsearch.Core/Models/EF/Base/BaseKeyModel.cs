namespace jobsearch.Core.Models.EF
{
    public class BaseKeyModel<TKey> : BaseCreationTrackerModel
    {
        [Key]
        public TKey Id { get; set; }
    }
}