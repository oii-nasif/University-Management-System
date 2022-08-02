using Entity.ViewModel;

namespace BusinessLayer.Interfaces
{
    public interface IViewResultVMService
    {
        List<ViewResultVM> GetStudentResult(int studentId);
    }
}
