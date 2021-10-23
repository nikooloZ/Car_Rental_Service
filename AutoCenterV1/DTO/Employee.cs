using AutoCenterV1.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenterV1.DTO
{
    public abstract class Employee : BaseEntity<int>
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "char(11)")]
        public string PersonalID { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [MaxLength(30)]
        public string Address { get; set; }


        [Required]
        [Column(TypeName = "char(20)")]
        public string TelNumber { get; set; }
    }

    public class Technician : Employee
    {
        [Required]
        public QualificationScale Qualification { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
    }

    public class Driver : Employee
    {
        [Required]
        public string LicenseNum { get; set; }

        [Required]
        public DriveingLicense LicenseCategory { get; set; }

        public Car Car { get; set; }
    }

    public class Administrator : Employee
    {
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Position { get; set; }

        [Required]
        public EducationScale Education { get; set; }
    }
}
