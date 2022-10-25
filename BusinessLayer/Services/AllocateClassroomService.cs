using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;

namespace BusinessLayer.Services
{
    public class AllocateClassroomService : IAllocateClassroomService
    {
        private readonly DataContext _dbContext;

        public AllocateClassroomService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool AllocateNewClassroom(AllocateClassroom allocateClassroom)
        {
            AllocateClassroom ac = new AllocateClassroom();
            List<AllocateClassroom> AC = new List<AllocateClassroom>();

            try
            {
                var res = _dbContext.AllocateClassrooms.Add(allocateClassroom);
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
