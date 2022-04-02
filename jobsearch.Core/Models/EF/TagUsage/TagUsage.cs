namespace jobsearch.Core.Models.EF
{
    public class TagUsageEntity : BaseModel<int>
    {
        public int ForeignTableIdentifier { get; set; }

        public string TableIdentifierPlain { get; set; }

        public int ForeignKey { get; set; }
    }
}