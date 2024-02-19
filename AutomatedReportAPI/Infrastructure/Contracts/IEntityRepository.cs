using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Common;

namespace AutomatedReportAPI.Infrastructure.Contracts
{
    public interface IUserRepository : IGenericRepository<User> { }
    public interface ITestRepository : IGenericRepository<Test> { }
    public interface ITest_MarkRepository : IGenericRepository<Test_Mark> { }
    public interface ITeacherRepository : IGenericRepository<Teacher> { }
    public interface ISubjectRepository : IGenericRepository<Subject> { }
    public interface IStudentRepository : IGenericRepository<Student> { }
    public interface ISessions_RecordRepository : IGenericRepository<Sessions_Record> { }
    public interface IScoreRepository : IGenericRepository<Score> { }
    public interface IPaymentRepository : IGenericRepository<Payment> { }
    public interface IDivisionRepository : IGenericRepository<Division> { }
    public interface IClassRepository : IGenericRepository<_Class> { }
    public interface ICertificateRepository : IGenericRepository<Certificate> { }
    public interface IAttendanceRepository : IGenericRepository<Attendance> { }
    public interface IAdvertisementRepository : IGenericRepository<Advertisement> { }
    public interface IDailySessions_RecordRepository : IGenericRepository<DailySessions_Record> { }
    public interface IHallRepository : IGenericRepository<Hall> { }

}