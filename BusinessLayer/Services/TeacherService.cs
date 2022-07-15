using BusinessLayer.Interfaces;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly DataContext _dbContext;

        public TeacherService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Teacher> GetList()
        {
            try
            {
                return _dbContext.Teachers.ToList();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
