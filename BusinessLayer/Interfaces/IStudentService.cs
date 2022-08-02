using Entity.Entities;

namespace BusinessLayer.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetList();
        public bool AddStudent(Student student);
        public int GetStudentsNumberByDeptId(int deptId, Student student);
    }
}
