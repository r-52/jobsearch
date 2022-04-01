using System.ComponentModel.DataAnnotations;

namespace jobsearch.Core.Models.EF
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int Revision { get; set; }
    }
}