using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class CourseAssignmentService : ICourseAssignmentService
    {
        private readonly DataContext _dbContext;

        public CourseAssignmentService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CourseAssignment> GetList()
        {
            try
            {
                return _dbContext.CourseAssignments.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public bool AddCourseAssignment(CourseAssignment courseAssignment)
        {
            var data = courseAssignment;
            try
            {
                
                Course course = _dbContext.Courses.SingleOrDefault(x => x.Id == data.CourseId);
                Teacher teacher = _dbContext.Teachers.SingleOrDefault(x => x.Id == data.TeacherId);

                if (teacher?.RemainingCredit >= course?.Credit)
                {
                    teacher.RemainingCredit = teacher.RemainingCredit - course.Credit;
                    
                }
                else
                {
                    return false;
                }

                var res = _dbContext.CourseAssignments.Add(courseAssignment);
                _dbContext.SaveChanges();
                if (res != null) return true;
                else return false;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool UnassignAllCourses()
        {
            List<CourseAssignment> assignedCourses = new List<CourseAssignment>();
            assignedCourses = _dbContext.CourseAssignments
                .Where(x => x.isAssigned == true)
                .ToList();

            try
            {
                foreach (CourseAssignment ca in assignedCourses)
                {
                    ca.isAssigned = false;
                }
                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }

        }

    }
}
