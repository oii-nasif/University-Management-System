using UCRMS_API.Model;

namespace BusinessLayer.Interfaces
{
    public interface ITeacherService
    {
        List<Teacher> GetList();
        List<Teacher> GetTeachersByDeptId(int deptId);
        double GetRemainingCreditByTeacherId(int teacherId);
        public bool AddTeacher(Teacher teacher);
    }
}
