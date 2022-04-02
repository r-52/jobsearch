namespace jobsearch.Core.Models.EF
{
    public class CompanyEntity : BaseModel<int>
    {
        public string Name { get; set; }

        public string? ProfileHeadline { get; set; }

        public string? ProfileHtmlBody { get; set; }

        public string? ProfilePlainBody { get; set; }

        public string? Address { get; set; }

        public int InstanceId { get; set; }

        public InstanceEntity Instance { get; set; }
    }
}