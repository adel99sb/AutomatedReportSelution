using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class Sessions_RecordRepository : GenericRepository<Sessions_Record>, ISessions_RecordRepository
    {
        public Sessions_RecordRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }

}
