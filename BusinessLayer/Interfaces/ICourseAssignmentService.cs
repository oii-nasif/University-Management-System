using Entity.Entities;

namespace BusinessLayer.Interfaces
{
    public interface ICourseAssignmentService
    {
        List<CourseAssignment> GetList();
        public bool AddCourseAssignment(CourseAssignment courseAssignment);
    }
}
