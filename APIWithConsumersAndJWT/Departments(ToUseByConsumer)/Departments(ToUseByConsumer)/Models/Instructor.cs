using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Departments_ToUseByConsumer_.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 9)]
        [RegularExpression(@"^\d{9}$")]
        public string SSN { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [Range(18, 120)]
        public int Age { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Salary { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        //public virtual Department Department { get; set; }
    }
}
