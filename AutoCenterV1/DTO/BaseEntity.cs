using System.ComponentModel.DataAnnotations;

namespace AutoCenterV1.DTO
{
    public class BaseEntity<TKey>
    {
        [Key]
        public virtual TKey ID { get; set; }
    }
}
