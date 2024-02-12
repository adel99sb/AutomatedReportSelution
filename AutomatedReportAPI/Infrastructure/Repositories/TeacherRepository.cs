using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }

}
