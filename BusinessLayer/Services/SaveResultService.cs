using BusinessLayer.Interfaces;
using Entity.Entities;
using UCRMS_API.Data;

namespace BusinessLayer.Services
{
    public class SaveResultService : ISaveResultService
    {
        public readonly DataContext _dbContext;
        public SaveResultService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddResult(SaveResult saveResult)
        {
            List<SaveResult> savedResult = new List<SaveResult>();
            savedResult = _dbContext.SaveResults
                    .Where(c => c.StudentId == saveResult.StudentId && c.CourseId == saveResult.CourseId)
                    .ToList();
            try
            {
                if (savedResult.Count > 0)
                {
                    return false;
                }
                
                var res = _dbContext.SaveResults.Add(saveResult);
                _dbContext.SaveChanges();
                if (res != null) return true;
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
