using System.ComponentModel.DataAnnotations;

namespace AutoCenterV1.Entities
{
    public class BaseEntity<TKey>
    {
        [Key]
        public virtual TKey ID { get; set; }
    }
}
