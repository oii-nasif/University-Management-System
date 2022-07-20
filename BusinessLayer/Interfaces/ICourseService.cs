using UCRMS_API.Model;

namespace BusinessLayer.Interfaces
{
    public interface ICourseService
    {
        List<Course> GetList();
        List<Course> GetDepartmentwiseList(int deptId);
        public bool AddCourse(Course course);
    }
}
