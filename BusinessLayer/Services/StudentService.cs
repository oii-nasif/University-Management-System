using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;

namespace BusinessLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _dbContext;

        public StudentService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Student> GetList()
        {
            try
            {
                return _dbContext.Students.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool AddStudent(Student student)
        {
            try
            {
                var departmentId = _dbContext.Departments.Find(student.DepartmentId);
                var countByDeptId = GetStudentsNumberByDeptId(student.DepartmentId) + 1;
                if (countByDeptId < 10) student.RegistrationNumber = $"{departmentId.Code}-{student.Date.Date.Year}-00{countByDeptId}";
                else if (countByDeptId >= 10 && countByDeptId < 100) student.RegistrationNumber = $"{departmentId.Code}-{student.Date.Date.Year}-0{countByDeptId}";
                else student.RegistrationNumber = $"{departmentId.Code}-{student.Date.Date.Year}-{countByDeptId}";

                var res = _dbContext.Students.Add(student);
                _dbContext.SaveChanges();
                if (res != null) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int GetStudentsNumberByDeptId(int deptId)
        {
            try
            {
                var studentsNumber = _dbContext.Students.Count(s => s.DepartmentId == deptId && s.Date.Date.Year == DateTime.Now.Year);
                return studentsNumber;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
