using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class ClassRepository : GenericRepository<_Class>, IClassRepository
    {
        public ClassRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }

}
