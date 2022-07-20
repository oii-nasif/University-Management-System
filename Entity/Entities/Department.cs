using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCRMS_API.Model;

namespace UCRMS_API.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Remote("CheckDepartmentName", "Department", ErrorMessage = "This Dept. Name Already Exist")]
        [Required(ErrorMessage = "Dept. name is a required field. ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Dept. code is a required field. ")]
       // [Remote("CheckDepartmentCode", "Department", ErrorMessage = "This Dept. Code Already Exist")]
        [StringLength(maximumLength: 7, MinimumLength = 2, ErrorMessage = "Department code must be between 2 to 7 character.")]
        public string Code { get; set; }
        public IList<Course>? Courses { get; set; }
        public IList<Teacher>? Teachers { get; set; }
    }
}
