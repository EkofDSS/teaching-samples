using Supabase.Core;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace ActorsRestService.Models
{
    [Table("Country")]
    public partial class Country: BaseModel
    {
        [PrimaryKey("code")]
        public string CountryCode { get; set; }

        [Column("name")]
        public string? CountryName { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
    }

}