using BusinessLayer.Interfaces;
using Entity.Entities;
using Entity.ViewModel;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class CourseStaticsVMService : ICourseStaticsVMService
    {

        private readonly DataContext _dbContext;

        public CourseStaticsVMService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CourseStaticsVM> GetCourseStatics(int deptId)
        {
            List<CourseStaticsVM> cs = new List<CourseStaticsVM>();
            List<Course> courseList = new List<Course>();
            courseList = _dbContext.Courses
                .Where(c => c.DepartmentId == deptId)
                .ToList();

            foreach (Course course in courseList)
            {
                Semester semester = new Semester();
                CourseAssignment courseAssignment = new CourseAssignment();
                Teacher teacher = new Teacher();

                semester = _dbContext.Semesters
                    .Where(s => s.Id == course.SemesterId)
                    .FirstOrDefault();

                courseAssignment = _dbContext.CourseAssignments
                    .Where(ca => ca.CourseId == course.Id)
                    .FirstOrDefault();

                teacher = _dbContext.Teachers
                    .Where(t => t.Id == courseAssignment.TeacherId)
                    .FirstOrDefault();

                /*List<CourseStaticsVM> cs_individual = new List<CourseStaticsVM>
                {
                    new CourseStaticsVM()
                    {
                        CourseCode = course.Code,
                        CourseName = course.Name,
                        SemesterName = semester.Name,
                        AssignedTo = teacher.Name  
                    }
                };*/

                cs.Add(
                    new CourseStaticsVM()
                    {
                        CourseCode = course.Code,
                        CourseName = course.Name,
                        SemesterName = semester.Name,
                        AssignedTo = teacher.Name
                    }
                );
                
            }
            return cs;
        }
    }
}
