using BusinessLayer.Interfaces;
using UCRMS_API.Data;
using UCRMS_API.Models;

namespace BusinessLayer.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DataContext _dbContext;

        public DepartmentService (DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Department> GetList()
        {
            try
            {
                return _dbContext.Departments.ToList();
            }
            catch(Exception ex)
            {
                throw;
            }

        }
    }
}
