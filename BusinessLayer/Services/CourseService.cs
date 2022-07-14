using BusinessLayer.Interfaces;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class CourseService: ICourseService
    {
        private readonly DataContext _dbcontext;

        public CourseService(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public List<Course> GetList()
        {
            try
            {
                return _dbcontext.Courses.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
           
        }
    }
}
