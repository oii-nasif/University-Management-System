using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCRMS_API.Models;

namespace UCRMS_API.Model
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Credit { get; set; }
        public string Description { get; set; }
        public int SemesterId { get; set; }
        public Semester? Semester { get; set; }
        public int DepartmentId { get; set; }
        public IList<Department>? Departments { get; set; }
        public IList<AllocateClassroom>? AllocateClassrooms { get; set; }
        public IList<CourseEnrollment>? CourseEnrollments { get; set; }

    }
}
