using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCRMS_API.Models;

namespace UCRMS_API.Model
{
    public class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public int DesignationId { get; set; }
        public int DepartmentId { get; set; }
        public double CreditToBeTaken  { get; set; }
        public Designation Designation { get; set; }
        public Department Department { get; set; }
    }
}
