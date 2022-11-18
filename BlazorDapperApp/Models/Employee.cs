using System.ComponentModel.DataAnnotations;

namespace BlazorDapperApp.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required,StringLength(20)]
        public string MobileNumber { get; set; }

    }
}
