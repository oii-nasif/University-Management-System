using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;

namespace BusinessLayer.Services
{
    public class RoomNoService : IRoomNoService
    {
        private readonly DataContext _dbContext;

        public RoomNoService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<RoomNo> GetList()
        {
            try
            {
                return _dbContext.RoomNos.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
