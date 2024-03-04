using AutomatedReportAPI.AppData.Context;
using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Common;
using AutomatedReportAPI.Infrastructure.Contracts;

namespace AutomatedReportAPI.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class Test_MarkRepository : GenericRepository<Test_Mark>, ITest_MarkRepository
    {
        public Test_MarkRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class Sessions_RecordRepository : GenericRepository<Sessions_Record>, ISessions_RecordRepository
    {
        public Sessions_RecordRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class ScoreRepository : GenericRepository<Score>, IScoreRepository
    {
        public ScoreRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class DivisionRepository : GenericRepository<Division>, IDivisionRepository
    {
        public DivisionRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }        
    }
    public class ClassRepository : GenericRepository<_Class>, IClassRepository
    {
        public ClassRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class CertificateRepository : GenericRepository<Certificate>, ICertificateRepository
    {
        public CertificateRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class AttendanceRepository : GenericRepository<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class AdvertisementRepository : GenericRepository<Advertisement>, IAdvertisementRepository
    {
        public AdvertisementRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class DailySessions_RecordRepository : GenericRepository<DailySessions_Record>, IDailySessions_RecordRepository
    {
        public DailySessions_RecordRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
    public class HallRepository : GenericRepository<Hall>, IHallRepository
    {
        public HallRepository(ApplicationDbContext DbContext)
            : base(DbContext) { }
    }
}