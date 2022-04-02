namespace jobsearch.Core.Models.EF
{
    public class BaseCreationTrackerModel
    {
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}