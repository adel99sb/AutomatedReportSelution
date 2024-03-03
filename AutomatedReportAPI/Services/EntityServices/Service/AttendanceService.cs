using AutomatedReport_DTOs;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.DTO_s.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class AttendanceService : IAttendanceService<IGeneralResponse>
    {
        public Task<IGeneralResponse> AddAttendance(AddAttendanceRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
