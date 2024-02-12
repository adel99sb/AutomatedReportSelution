using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class ScoreRepository : GenericRepository<Score>, IScoreRepository
    {
        public ScoreRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }

}
