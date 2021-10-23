using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenterV1.DTO
{
    public class Category : BaseEntity<int>
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public Technician Technician { get; set; }
        public ICollection<Car> Car { get; set; }
    }
    public class Car : BaseEntity<int>
    {
        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int ClassID { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string CarNumber { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public double Price { get; set; }
    }
}
