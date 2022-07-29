using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UCRMS_API.Model;

namespace Entity.Entities
{
    public class SaveResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int GradeLetterId { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }
        public GradeLetter? GradeLetter { get; set; }
    }
}
