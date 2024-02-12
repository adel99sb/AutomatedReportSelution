using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }

}
