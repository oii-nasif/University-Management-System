using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;

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
            try
            {
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

    }
}
