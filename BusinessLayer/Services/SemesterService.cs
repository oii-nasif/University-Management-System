using BusinessLayer.Interfaces;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class SemesterService : ISemesterService
    {
        private readonly DataContext _dbContext;

        public SemesterService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Semester> GetList()
        {
            try
            {
                return _dbContext.Semesters.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
