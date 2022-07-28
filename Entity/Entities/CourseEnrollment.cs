using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCRMS_API.Model;
using UCRMS_API.Models;

namespace Entity.Entities
{
    public class CourseEnrollment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public bool isEnrolled { get; set; } = false;
        public Student? Student { get; set; }
        public Course? Course { get; set; }
        public DateTime Date { get; set; }
    }
}
