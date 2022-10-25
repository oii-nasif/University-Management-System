using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCRMS_API.Model;
using UCRMS_API.Models;

namespace Entity.Entities
{
    public class AllocateClassroom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int RoomNoId { get; set; }
        public int DayId { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public Day? Day { get; set; }
        public RoomNo? RoomNo { get; set; }
        public Department? Department { get; set; }
        public Course? Course { get; set; }
        public string? FromTime { get; set; }
        public string? ToTime { get; set; }

    }
}
