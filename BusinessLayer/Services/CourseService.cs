using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class CourseService: ICourseService
    {
        private readonly DataContext _dbContext;

        public CourseService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Course> GetList()
        {
            try
            {
                return _dbContext.Courses.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
           
        }
        public List<Course> GetCoursesByDeptId(int deptId)
        {
            try
            {
                return _dbContext.Courses.Where(x => x.DepartmentId == deptId).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Course> GetCoursesByStudent(int studentId)
        {
            List<CourseEnrollment> courseEnrollment = new List<CourseEnrollment>();
            courseEnrollment = _dbContext.CourseEnrollments
                .Where(x => x.StudentId == studentId)
                .ToList();
            List<Course> course = new List<Course>();
            Course c = new Course();
            try
            {
                foreach (CourseEnrollment ce in courseEnrollment)
                {
                    c = _dbContext.Courses
                        .Where(x => x.Id == ce.CourseId)
                        .FirstOrDefault();
                    course.Add(c);
                }

                return course;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool AddCourse(Course course)
        {
            try
            {
                var res = _dbContext.Courses.Add(course);
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
