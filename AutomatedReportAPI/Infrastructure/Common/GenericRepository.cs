using AutomatedReportAPI.AppData.Context;
using Microsoft.EntityFrameworkCore;

namespace AutomatedReportAPI.Infrastructure.Common
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : class
    {
        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
////var ?? = new ??();
//IGeneralResponse response;
//try
//{
//    //var ?? = this.??();
//    //Logic
//    //if (?? != null)
//    {
//        //response = new ??(??);
//        //response.StatusCode = Requests_Status.??;
//        //response.Message = "?? Successfully";
//    }
//    else
//    {
//        response = new GeneralResponse(null);
//        //response.StatusCode = Requests_Status.??;
//        //response.Message = "??";
//    }
//}
//catch (Exception ex)
//{
//    response = new GeneralResponse(null);
//    response.StatusCode = Requests_Status.InternalServerError;
//    response.Message = ex.Message;
//}
//return response;
