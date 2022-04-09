namespace jobsearch.Core.Models.EF
{
    public class JobEntity : BaseModel<int>
    {
        public string HeadlinePlain { get; set; }

        public string HeadlineHtml { get; set; }

        public string? BodyPlain { get; set; }

        public string? BodyHtml { get; set; }

        public string? IntroImageUrl { get; set; }

        public string? FooterImageUrl { get; set; }

        public string? ExternalApplyUrl { get; set; }

        public string Slug { get; set; }

        public bool IsOnline { get; set; }

        public bool IsDraft { get; set; }

        public bool IsArchived { get; set; }

        public DateTime? OnlineFrom { get; set; }

        public DateTime? OnlineTill { get; set; }

        public int JobTypeId { get; set; }

        public JobTypeEntity JobType { get; set; }

        public int InstanceId { get; set; }

        public InstanceEntity Instance { get; set; }
    }
}
