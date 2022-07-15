using UCRMS_API.Model;

namespace BusinessLayer.Interfaces
{
    public interface ICourseService
    {
        List<Course> GetList();
        public bool AddCourse(Course course);
    }
}
