using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class SaveResultService : ISaveResultService
    {
        public readonly DataContext _dbContext;
        public SaveResultService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CourseEnrollment> GetEnrolledCourses(int studentId)
        {
            List<Course> course = new List<Course>();
            List<CourseEnrollment> cen = new List<CourseEnrollment>();
           

            cen = _dbContext.CourseEnrollments
                    .Where(x => x.StudentId == studentId)
                    .ToList();
            /*Course c = new Course();
            foreach (CourseEnrollment ce in cen)
            {
                c = _dbContext.Courses
                    .Where(cs => cs.Id == ce.CourseId)
                    .FirstOrDefault();

                if(c!= null)
                {
                    course.Add(c);
                }
                
            }*/

            return cen;
           
            
        }

        public bool AddResult(SaveResult saveResult)
        {
            List<SaveResult> savedResult = new List<SaveResult>();
            savedResult = _dbContext.SaveResults
                    .Where(c => c.StudentId == saveResult.StudentId && c.CourseId == saveResult.CourseId)
                    .ToList();
            try
            {
                if (savedResult.Count > 0)
                {
                    return false;
                }
                
                var res = _dbContext.SaveResults.Add(saveResult);
                _dbContext.SaveChanges();
                if (res != null) return true;
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
