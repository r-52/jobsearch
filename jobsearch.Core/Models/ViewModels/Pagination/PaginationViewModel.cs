namespace jobsearch.Core.Models.ViewModels
{
    public class PaginationQueryViewModel
    {
        public int? Page { get; set; }

        public int? PageSize { get; set; }

        public string? Query { get; set; }
    }
}
