using UCRMS_API.Model;

namespace BusinessLayer.Interfaces
{
    public interface ICourseService
    {
        List<Course> GetList();
        List<Course> GetCoursesByDeptId(int deptId);
        List<Course> GetCoursesByStudent(int studentId);
        public bool AddCourse(Course course);
    }
}
