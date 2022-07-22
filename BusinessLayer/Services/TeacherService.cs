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

        public List<Teacher> GetTeachersByDeptId(int deptId)
        {
            try
            {
                return _dbContext.Teachers.Where(x => x.DepartmentId == deptId).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public double GetRemainingCreditByTeacherId(int teacherId)
        {
            try
            {
                var teacher = _dbContext.Teachers.FirstOrDefault(t => t.Id == teacherId);
                return teacher.RemainingCredit;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool AddTeacher(Teacher teacher)
        {
            try
            {
                var res = _dbContext.Teachers.Add(teacher);
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
