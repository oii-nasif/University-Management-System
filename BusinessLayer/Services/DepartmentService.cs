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

        public bool AddDepartment(Department dept)
        {
            try
            {
                var res = _dbContext.Departments.Add(dept);
                _dbContext.SaveChanges();
                if (res != null) return true; 
                else return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string GetDepartmentName(int deptId)
        {
            try
            {
                var department = _dbContext.Departments.FirstOrDefault(d => d.Id == deptId);
                return department.Name;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
