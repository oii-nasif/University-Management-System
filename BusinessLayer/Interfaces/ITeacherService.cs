using UCRMS_API.Model;

namespace BusinessLayer.Interfaces
{
    public interface ITeacherService
    {
        List<Teacher> GetList();
        List<Teacher> GetDepartmentwiseList(int deptId);
        public bool AddTeacher(Teacher teacher);
    }
}
