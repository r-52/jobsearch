using System.ComponentModel.DataAnnotations;

namespace jobsearch.Core.Models.EF
{
    public class BaseModel<TKey> : BaseKeyModel<TKey>
    {
        public int Revision { get; set; }
    }
}