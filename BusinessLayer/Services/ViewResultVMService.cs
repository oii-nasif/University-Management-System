using BusinessLayer.Interfaces;
using Entity.Entities;
using Entity.ViewModel;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class ViewResultVMService : IViewResultVMService
    {
        public readonly DataContext _dbContext;
        public ViewResultVMService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ViewResultVM> GetStudentResult(int studentId)
        {
            List<ViewResultVM> vr = new List<ViewResultVM>();
            List<CourseEnrollment> courseList = new List<CourseEnrollment>();
            courseList = _dbContext.CourseEnrollments
                .Where(c => c.StudentId == studentId)
                .ToList();

            foreach (CourseEnrollment ce in courseList)
            {
                Course course = new Course();
                GradeLetter grade = new GradeLetter();
                SaveResult record = new SaveResult();
                


                course = _dbContext.Courses
                    .Where(c => c.Id == ce.CourseId)
                    .FirstOrDefault();

                record = _dbContext.SaveResults
                    .Where(r => r.CourseId == ce.CourseId)
                    .FirstOrDefault();

                if (record != null)
                {
                    grade = _dbContext.GradeLetters
                    .Where(g => g.Id == record.GradeLetterId)
                    .FirstOrDefault();

                    vr.Add(
                        new ViewResultVM()
                        {
                            CourseCode = course.Code,
                            CourseName = course.Name,
                            Grade = grade.Name,
                        }
                    );
                }

                else
                {
                    vr.Add(
                        new ViewResultVM()
                        {
                            CourseCode = course.Code,
                            CourseName = course.Name,
                            Grade = "Not Graded Yet",
                        }
                    );
                }
                

            }

            return vr;
        }
    }
}
