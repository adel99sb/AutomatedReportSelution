using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class AttendanceService : IAttendanceService<GeneralResponse>
    {
        public Task<GeneralResponse> AddAttendance(AddAttendanceRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
