using Entity.Entities;
using UCRMS_API.Model;

namespace BusinessLayer.Interfaces
{
    public interface ICourseEnrollmentService
    {
        public bool CourseEnrollment(CourseEnrollment courseEnrollment);
    }
}
