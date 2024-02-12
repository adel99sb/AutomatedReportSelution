using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }

}
