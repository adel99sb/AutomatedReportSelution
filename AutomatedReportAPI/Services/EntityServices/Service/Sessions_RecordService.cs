using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure.Common;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;
using AutomatedReportCore.Responces.AdminDashboard;
using AutomatedReportCore.Responces.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class Sessions_RecordService : ISessions_RecordService<GeneralResponse>
    {
        private readonly IGenericRepository<Sessions_Record> sessions_RecordRepository;
        public Sessions_RecordService(IGenericRepository<Sessions_Record> sessions_RecordRepository)
        {
            this.sessions_RecordRepository = sessions_RecordRepository;
        }

        public Task<GeneralResponse> AddSession(AddSessionRequste requste)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> DeleteSession(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> EditeSession(EditeSessionRequste requste)
        {
            throw new NotImplementedException();
        }

        public async Task<GeneralResponse> GetAllDays()
        {
            GetAllDaysResponse data = new();
            GeneralResponse response;
            try
            {
                for (int i = 0; i < 7; i++)
                {
                    data.days.Add(new DayDto()
                    {
                        Id = i,
                        Day = ((DayOfWeek)i).ToString()
                    });
                }                
                response = new GeneralResponse(data);
                response.StatusCode = Requests_Status.Ok;
                response.Message = "Sii";
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(data);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public Task<GeneralResponse> GetAllSessions(Guid divisionId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponse> GetAllSessionsByDay(GetAllSessionsByDayRequste requste)
        {
            throw new NotImplementedException();
        }

        public async Task<GeneralResponse> GetAllSessionsGroupedByDays(Guid divisionId)
        {
            GetAllSessionsGroupedByDaysResponse data = new();
            List<GroupedSessionDto> Sessions;
            GeneralResponse response;
            try
            {
                var filteredSessions = sessions_RecordRepository.GetAll()
                    .Where(s => s.Division.Id == divisionId)
                    .Include(c => c._Class)
                    .Include(s => s.Subject)
                    .Include(h => h.Hall)
                    .ToList(); // Load data into memory

                var daySessions = filteredSessions
                    .GroupBy(s => s.day)
                    .ToDictionary(g => g.Key, g => g.ToList());
                foreach (var item in daySessions)
                {
                    Sessions = new();
                    foreach (var session in item.Value)
                    {
                        Sessions.Add(new GroupedSessionDto()
                        {
                            Id = session.Id,
                            Class = session._Class.Name,
                            From_Time = session._Class.From_Time,
                            To_Time = session._Class.To_Time,
                            Subject = session.Subject.Name,
                            Hall = session.Hall.Name
                        });
                    }                    
                    data.daySessions.Add(item.Key,Sessions);
                }
                response = new GeneralResponse(data);
                response.StatusCode = Requests_Status.Ok;
                response.Message = "Siii";
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
