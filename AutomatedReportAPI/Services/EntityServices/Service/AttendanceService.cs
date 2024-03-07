using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Common;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;
using Microsoft.EntityFrameworkCore;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class AttendanceService : IAttendanceService<GeneralResponse>
    {
        private readonly IAttendanceRepository attendanceRepository;
        public AttendanceService(IAttendanceRepository attendanceRepository)
        {
            this.attendanceRepository = attendanceRepository;              
        }

        public async Task<GeneralResponse> AddAttendance(AddAttendanceRequste requste)
        {
            GeneralResponse response;
            try
            {
                var Attendances = attendanceRepository.GetAll()
                    .Include(s => s.Student)
                    .Include(d => d.DailySessions_Record).ToList();
                foreach (var item in requste.AttendancesList)
                {
                    var Student = Attendances.Find(s => s.Student.Id == item.StudentId)?.Student;
                    var DailySessions_Record = Attendances
                        .Find(d => d.DailySessions_Record.Id == item.DailySessions_RecordId)
                        ?.DailySessions_Record;
                    await attendanceRepository.Create(new Attendance()
                    {
                        Enter_Time = item.Enter_Time,
                        Outer_Time = item.Outer_Time,
                        Student = Student,
                        DailySessions_Record = DailySessions_Record
                    });
                }
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Attendances Added Succesfully";                
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
