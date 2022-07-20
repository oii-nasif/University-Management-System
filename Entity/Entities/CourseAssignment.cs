using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCRMS_API.Model;
using UCRMS_API.Models;

namespace Entity.Entities
{
    public class CourseAssignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        /*public int DepartmentId { get; set; }*/
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public bool isAssigned { get; set; }
        public bool isValidOperation { get; set; }
        /*public Department? Department { get; set; }*/
        public Teacher? Teacher { get; set; }
        public Course? Course { get; set; }
    }
}
