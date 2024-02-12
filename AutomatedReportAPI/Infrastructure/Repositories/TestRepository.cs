using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }

}
