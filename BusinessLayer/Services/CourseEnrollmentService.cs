using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;
using UCRMS_API.Model;
using UCRMS_API.Models;

namespace BusinessLayer.Services
{
    public class CourseEnrollmentService : ICourseEnrollmentService 
    {
        private readonly DataContext _dbContext;

        public CourseEnrollmentService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CourseEnrollment(CourseEnrollment courseEnrollment)
        {

            List<CourseEnrollment> studentList = new List<CourseEnrollment>();
            studentList = _dbContext.CourseEnrollments
                .Where(c => c.StudentId == courseEnrollment.StudentId && c.CourseId == courseEnrollment.CourseId)
                .ToList();

            try
            {
                if (studentList.Count > 0)
                {
                    return false;
                }
                var res = _dbContext.CourseEnrollments.Add(courseEnrollment);
                _dbContext.SaveChanges();
                if (res != null) return true;
                else return false;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
