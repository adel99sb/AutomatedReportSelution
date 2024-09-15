using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Responces;
using AutomatedReportCore.Responces.AdminDashboard;
using Microsoft.EntityFrameworkCore;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class StatisticsService : IStatisticsService<GeneralResponse>
    {
        private readonly IUnitOfWork<Student> _studentService;
        private readonly IUnitOfWork<Hall> _hallService;
        private readonly IUnitOfWork<Division> _divisionService;
        private readonly IUnitOfWork<Teacher> _teacherService;
        public StatisticsService(
            IUnitOfWork<Student> studentService,
            IUnitOfWork<Hall> hallService,
            IUnitOfWork<Division> divisionService,
            IUnitOfWork<Teacher> teacherService
            )
        {
            _studentService = studentService;
            _hallService = hallService;
            _divisionService = divisionService;
            _teacherService = teacherService;
        }
        public async Task<GeneralResponse> GetAll()
        {
            var Data = new GetAllStatisticsReResponse();
            GeneralResponse response;
            try
            {
                var MailNumber = _studentService.GetAll()
                    .Where(s => s.Gender == "ذكر")
                    .Count();

                var FemailNumber = _studentService.GetAll()
                    .Where(s => s.Gender == "أنثى")
                    .Count();

                var basicCertificateNumber = _studentService.GetAll()
                    .Include(d => d.Division)
                    .ThenInclude(c => c.Certificate)
                    .Where(s => s.Division.Certificate.Name
                                == "الشهادة الإعدادية")
                    .Count();

                var scientificCertificateNumber = _studentService.GetAll()
                    .Include(d => d.Division)
                    .ThenInclude(c => c.Certificate)
                    .Where(s => s.Division.Certificate.Name
                                == "الشهادة الثانوية - علمي")
                    .Count();

                var literaryCertificateNumber = _studentService.GetAll()
                    .Include(d => d.Division)
                    .ThenInclude(c => c.Certificate)
                    .Where(s => s.Division.Certificate.Name
                                == "الشهادة الثانوية - أدبي")
                    .Count();

                var Divisons = _divisionService.GetAll()                    
                    .Count();

                var basicCertificateDivisionNumber = _divisionService.GetAll()
                    .Include(c => c.Certificate)
                    .Where(s => s.Certificate.Name
                                == "الشهادة الإعدادية")
                    .Count();

                var literaryCertificateDivisionNumber = _divisionService.GetAll()
                    .Include(c => c.Certificate)
                    .Where(s => s.Certificate.Name
                                == "الشهادة الثانوية - أدبي")
                    .Count();

                var scientificCertificateDivisionNumber = _divisionService.GetAll()
                    .Include(c => c.Certificate)
                    .Where(s => s.Certificate.Name
                                == "الشهادة الثانوية - علمي")
                    .Count();

                var Teachers = _teacherService.GetAll().Count();
                
                var Halls = _hallService.GetAll().Count();

                Data = new GetAllStatisticsReResponse()
                {
                    MailNumber = MailNumber,
                    FemailNumber = FemailNumber,
                    basicCertificateNumber = basicCertificateNumber,
                    scientificCertificateNumber = scientificCertificateNumber,
                    literaryCertificateNumber = literaryCertificateNumber,
                    basicCertificateDivisionNumber = basicCertificateDivisionNumber,
                    literaryCertificateDivisionNumber = literaryCertificateDivisionNumber,
                    scientificCertificateDivisionNumber = scientificCertificateDivisionNumber,
                    DivisonNumber = Divisons,
                    HallNumber = Halls,
                    TeacherNumber = Teachers
                };
                response = new GeneralResponse(Data);
                response.StatusCode = Requests_Status.Ok;
                response.Message = "Get Statistics Succesfully";

            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
