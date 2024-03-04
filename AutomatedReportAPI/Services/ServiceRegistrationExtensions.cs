using AutomatedReportAPI.Controllers.AdminDashboard;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Infrastructure.Repositories;
using AutomatedReportAPI.Services.BackgroundJobs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportAPI.Services.EntityServices.Service;
using AutomatedReportCore.Responces;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedReportAPI.Services
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IAdvertisementRepository, AdvertisementRepository>()
                .AddScoped<IAttendanceRepository, AttendanceRepository>()
                .AddScoped<IClassRepository, ClassRepository>()
                .AddScoped<IPaymentRepository, PaymentRepository>()
                .AddScoped<IScoreRepository, ScoreRepository>()
                .AddScoped<ISessions_RecordRepository, Sessions_RecordRepository>()
                .AddScoped<IStudentRepository, StudentRepository>()
                .AddScoped<ISubjectRepository, SubjectRepository>()
                .AddScoped<ITeacherRepository, TeacherRepository>()
                .AddScoped<ITestRepository, TestRepository>()
                .AddScoped<ITest_MarkRepository, Test_MarkRepository>()
                .AddScoped<IDivisionRepository, DivisionRepository>()
                .AddScoped<IHallRepository, HallRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IDailySessions_RecordRepository, DailySessions_RecordRepository>()
                .AddScoped<ICertificateRepository, CertificateRepository>();
        }
        public static IServiceCollection AddBackgourndJob(this IServiceCollection services)
        {
            return services
                .AddScoped<IBackgourndJobService, BackgourndJobService>();
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IUserService<GeneralResponse>), typeof(UserService))
                .AddScoped(typeof(IUserService<IActionResult>), typeof(UserController))

                .AddScoped(typeof(ICertificateService<GeneralResponse>), typeof(CertificateService))
                .AddScoped(typeof(ICertificateService<IActionResult>), typeof(CertificateController))

                .AddScoped(typeof(ISubjectService<GeneralResponse>), typeof(SubjectService))
                .AddScoped(typeof(ISubjectService<IActionResult>), typeof(SubjectController))

                .AddScoped(typeof(IDivisionService<GeneralResponse>), typeof(DivisionService))
                .AddScoped(typeof(IDivisionService<IActionResult>), typeof(DivisionController))

                .AddScoped(typeof(IClassService<GeneralResponse>), typeof(ClassService))
                .AddScoped(typeof(IClassService<IActionResult>), typeof(ClassController))

                .AddScoped(typeof(IAttendanceService<GeneralResponse>), typeof(AttendanceService))
                .AddScoped(typeof(IAttendanceService<IActionResult>), typeof(AttendanceController))

                .AddScoped(typeof(IDailySessionsService<GeneralResponse>), typeof(DailySessionsService))
                .AddScoped(typeof(IDailySessionsService<IActionResult>), typeof(DailySessionsController))

                .AddScoped(typeof(IHallService<GeneralResponse>), typeof(HallService))
                .AddScoped(typeof(IHallService<IActionResult>), typeof(HallController))

                .AddScoped(typeof(IPaymentService<GeneralResponse>), typeof(PaymentService))
                .AddScoped(typeof(IPaymentService<IActionResult>), typeof(PaymentController))

                .AddScoped(typeof(ISessions_RecordService<GeneralResponse>), typeof(Sessions_RecordService))
                .AddScoped(typeof(ISessions_RecordService<IActionResult>), typeof(Sessions_RecordController))

                .AddScoped(typeof(IStudentService<GeneralResponse>), typeof(StudentService))
                .AddScoped(typeof(IStudentService<IActionResult>), typeof(StudentController))

                .AddScoped(typeof(ITeacherService<GeneralResponse>), typeof(TeacherService))
                .AddScoped(typeof(ITeacherService<IActionResult>), typeof(TeacherController))

                .AddScoped(typeof(ITestService<GeneralResponse>), typeof(TestService))
                .AddScoped(typeof(ITestService<IActionResult>), typeof(TestController))

                .AddScoped(typeof(ITestMarkService<GeneralResponse>), typeof(TestMarkService))
                .AddScoped(typeof(ITestMarkService<IActionResult>), typeof(Test_MarkController));
        }
    } 
}