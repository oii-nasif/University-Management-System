using Entity.Entities;
using UCRMS_API.Model;

namespace BusinessLayer.Interfaces
{
    public interface ISaveResultService
    {
        public bool AddResult(SaveResult saveResult);
        List<CourseEnrollment> GetEnrolledCourses(int studentId);
    }

}
