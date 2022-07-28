using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;

namespace BusinessLayer.Services
{
    public class GradeLetterService : IGradeLetterService
    {
        private readonly DataContext _dbContext;

        public GradeLetterService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GradeLetter> GetList()
        {
            try
            {
                return _dbContext.GradeLetters.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
