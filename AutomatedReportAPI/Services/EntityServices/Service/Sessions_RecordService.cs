using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure;
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
        private readonly IUnitOfWork<Sessions_Record> sessions_RecordRepository;
        public Sessions_RecordService(IUnitOfWork<Sessions_Record> sessions_RecordRepository)
        {
           this.sessions_RecordRepository = sessions_RecordRepository;
        }

        public async Task<GeneralResponse> AddSession(AddSessionRequste requste)
        {
            GeneralResponse response;
            try
            {
                var Sessions = sessions_RecordRepository.GetAll()
                    .Include(d => d.Division)
                    .Include(h => h.Hall)
                    .Include(s => s.Subject)
                    .Include(c => c._Class)
                    .ToList();
                var divison = Sessions
                    .Find(d => d.Division.Id == requste.DivisionId)?.Division;
                var hall = Sessions
                    .Find(h => h.Hall.Id == requste.HallId)?.Hall;
                var subject = Sessions
                    .Find(s => s.Subject.Id == requste.SubjectId)?.Subject;
                var Class = Sessions
                    .Find(c => c._Class.Id == requste._ClassId)?._Class;
                await sessions_RecordRepository.Create(new Sessions_Record()
                {
                    day = requste.day,
                    Division = divison,
                    _Class = Class,
                    Hall = hall,
                    Subject = subject
                });
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Sessions Added Succesfully";
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> DeleteSession(Guid id)
        {
            GeneralResponse response;
            try
            {
                await sessions_RecordRepository.Delete(id);

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Sessions Deleted Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> EditeSession(EditeSessionRequste requste)
        {
            GeneralResponse response;
            try
            {
                var Sessions = sessions_RecordRepository.GetAll()
                    .Include(d => d.Division)
                    .Include(h => h.Hall)
                    .Include(s => s.Subject)
                    .Include(c => c._Class)
                    .ToList();
                var divison = Sessions
                    .Find(d => d.Division.Id == requste.DivisionId)?.Division;
                var hall = Sessions
                    .Find(h => h.Hall.Id == requste.HallId)?.Hall;
                var subject = Sessions
                    .Find(s => s.Subject.Id == requste.SubjectId)?.Subject;
                var Class = Sessions
                    .Find(c => c._Class.Id == requste._ClassId)?._Class;
                await sessions_RecordRepository.Update(new Sessions_Record()
                {
                    Id = requste.Id,
                    day = requste.day,
                    Division = divison,
                    _Class = Class,
                    Hall = hall,
                    Subject = subject
                });
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Sessions Updated Succesfully";
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllDays()
        {
            var Data = new GetAllDaysResponse();
            GeneralResponse response;
            try
            {
                for (int i = 0; i < 7; i++)
                {
                    Data.days.Add(new DayDto()
                    {
                        Id = i,
                        Day = ((DayOfWeek)i).ToString()
                    });
                }                
                response = new GeneralResponse(Data);
                response.StatusCode = Requests_Status.Ok;
                response.Message = "Get Days Succesfully";
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllSessions(Guid divisionId)
        {
            var Data = new GetAllSessionsResponse();
            GeneralResponse response;
            try
            {
                var Sessions = sessions_RecordRepository.GetAll()
                    .Where(s => s.Division.Id == divisionId)
                    .Include(c => c._Class)
                    .Include(s => s.Subject)
                    .Include(h => h.Hall)
                    .ToList(); // Load data into memory
                foreach (var item in Sessions)
                {
                    Data.sessions.Add(new SessionDto()
                    {
                        Id = item.Id,
                        Day = item.day,
                        Class = item._Class.Name,
                        Hall = item.Hall.Name,
                        Subject = item.Subject.Name
                    });
                }
                if (Data.sessions.Count != 0)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Sessions Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Sessions Found !!";
                }
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllSessionsByDay(GetAllSessionsByDayRequste requste)
        {
            var Data = new GetAllSessionsByDayResponse();
            GeneralResponse response;
            try
            {
                var Sessions = sessions_RecordRepository.GetAll()
                    .Where(s => s.Division.Id == requste.DivisionId
                             && s.day == requste.Day)
                    .Include(c => c._Class)
                    .Include(s => s.Subject)
                    .Include(h => h.Hall)
                    .ToList(); // Load data into memory
                foreach (var item in Sessions)
                {
                    Data.sessions.Add(new SessionDto()
                    {
                        Id = item.Id,
                        Day = item.day,
                        Class = item._Class.Name,
                        Hall = item.Hall.Name,
                        Subject = item.Subject.Name
                    });
                }
                if (Data.sessions.Count != 0)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Sessions Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Sessions Found !!";
                }
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllSessionsGroupedByDays(Guid divisionId)
        {
            var Data = new GetAllSessionsGroupedByDaysResponse();
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
                    Data.daySessions.Add(item.Key,Sessions);
                }
                if (Data.daySessions.Count != 0)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Sessions Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Sessions Found !!";
                }
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
