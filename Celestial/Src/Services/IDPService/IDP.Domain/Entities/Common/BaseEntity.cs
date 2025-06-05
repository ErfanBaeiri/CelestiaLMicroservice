using System.ComponentModel.DataAnnotations;

namespace IDP.Domain.Entities.Common
{
    public class BaseEntity
    {

        [Key]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdateDates { get; set; } 
    }
}
