using Entity.ViewModel;

namespace BusinessLayer.Interfaces
{
    public interface ICourseStaticsVMService
    {
        List<CourseStaticsVM> GetCourseStatics(int deptId);
    }
}
