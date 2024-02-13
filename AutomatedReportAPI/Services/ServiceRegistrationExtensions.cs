using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Infrastructure.Repositories;
using AutomatedReportAPI.Services.BackgroundJobs;

namespace AutomatedReportAPI.Services
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection AddMyRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IAdvertisementRepository, AdvertisementRepository>()
                .AddScoped<IAttendanceRepository, AttendanceRepository>()
                .AddScoped<ICertificateRepository, CertificateRepository>()
                .AddScoped<IClassRepository, ClassRepository>()
                .AddScoped<IDivisionRepository, DivisionRepository>()
                .AddScoped<IPaymentRepository, PaymentRepository>()
                .AddScoped<IScoreRepository, ScoreRepository>()
                .AddScoped<ISessions_RecordRepository, Sessions_RecordRepository>()
                .AddScoped<IStudentRepository, StudentRepository>()
                .AddScoped<ISubjectRepository, SubjectRepository>()
                .AddScoped<ITeacherRepository, TeacherRepository>()
                .AddScoped<ITestRepository, TestRepository>()
                .AddScoped<ITest_MarkRepository, Test_MarkRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                // To Remove later
                .AddScoped<IBackgourndJobService,BackgourndJobService>();
        }
    }
}
