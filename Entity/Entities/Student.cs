using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCRMS_API.Model;
using UCRMS_API.Models;

namespace Entity.Entities
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string? RegistrationNumber { get; set; } 
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public IList<CourseEnrollment>? CourseEnrollments { get; set; }
        public IList<SaveResult>? saveResults { get; set; }
    }
}
