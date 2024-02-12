using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class Test_MarkRepository : GenericRepository<Test_Mark>, ITest_MarkRepository
    {
        public Test_MarkRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }

}
