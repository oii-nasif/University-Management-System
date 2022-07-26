using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;

namespace BusinessLayer.Services
{
    public class DayService : IDayService
    {
        private readonly DataContext _dbContext;

        public DayService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Day> GetList()
        {
            try
            {
                return _dbContext.Days.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
