using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Requstes.DTOs;
using AutomatedReportCore.Responces;
using AutomatedReportCore.Responces.AdminDashboard;
using Microsoft.EntityFrameworkCore;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class AttendanceService : IAttendanceService<GeneralResponse>
    {
        private readonly IUnitOfWork<Attendance> attendanceRepository;
        public AttendanceService(IUnitOfWork<Attendance> attendanceRepository)
        {
            this.attendanceRepository = attendanceRepository;
        }

        public async Task<GeneralResponse> EditeAttendance(EditeAttendanceRequste requste)
        {
            GeneralResponse response;
            try
            {
                foreach (var item in requste.AttendancesList)
                {
                    await attendanceRepository.Update(new Attendance()
                    {
                        Id = item.Id,
                        DailySessions_RecordId = item.DailySessions_RecordId,
                        IsAttend = item.IsAttend,
                        StudentId = item.StudentId
                    });
                }
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Attendances Edited Succesfully";
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAttendanceByDate(DateTime date, Guid DivisionId)
        {
            GetAttendanceByDateResponse Data = new GetAttendanceByDateResponse();
            GeneralResponse response;
            try
            {
                var Attendances = attendanceRepository.GetAll()
                    .Include(s => s.Student)
                    .Include(d => d.DailySessions_Record)
                    .ThenInclude(s => s.Sessions_Record)
                    .Include(c => c.DailySessions_Record.Sessions_Record.Class)
                    .Include(c => c.DailySessions_Record.Sessions_Record.Hall)
                    .Include(c => c.DailySessions_Record.Sessions_Record.Subject)
                    .Where(a => a.DailySessions_Record.Sessions_Record.DivisionId
                            == DivisionId
                            && a.DailySessions_Record.Date.Date == date.Date)
                    .ToList();

                foreach (var item in Attendances)
                {
                    Data.Time = item.DailySessions_Record.Sessions_Record.Class.Name;
                    Data.Hall = item.DailySessions_Record.Sessions_Record.Hall.Name;
                    Data.Subject = item.DailySessions_Record.Sessions_Record.Subject.Name;
                    Data.SubjectTitle = item.DailySessions_Record.Subject_Title;                    
                    Data.attendances.Add(new GetAttendanceDto()
                    {
                        Id = item.Id,
                        FirstName = item.Student.First_Name,
                        LastName = item.Student.Last_Name,
                        IsAttend = item.IsAttend,
                        StudentId = item.StudentId
                    });
                }
                response = new GeneralResponse(Data);
                response.Message = "Get All Attendances Succesfully";
                response.StatusCode = Requests_Status.Ok;
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
