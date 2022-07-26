using UCRMS_API.Model;

namespace BusinessLayer.Interfaces
{
    public interface ISemesterService
    {
        List<Semester> GetList();
        string GetSemesterName(int semesterId);
    }
}
