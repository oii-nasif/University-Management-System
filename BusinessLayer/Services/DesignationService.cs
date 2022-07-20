using BusinessLayer.Interfaces;
using UCRMS_API.Data;
using UCRMS_API.Model;

namespace BusinessLayer.Services
{
    public class DesignationService : IDesignationService
    {
        private readonly DataContext _dbContext;

        public DesignationService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Designation> GetList()
        {
            try
            {
                return _dbContext.Designations.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
