using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenterV1.DTO
{
    public class Customer : BaseEntity<int>
    {       
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName ="char(11)")]
        public string PersonalID { get; set; }


        [Required]
        [MaxLength(30)]
        public string Address { get; set; }

        [Required]
        [Column(TypeName ="char(20)")]
        public string TelNumber { get; set; }
    }
}
