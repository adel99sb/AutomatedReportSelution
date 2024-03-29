﻿using AutomatedReportAPI.AppData.Models;
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
    public class DailySessionsService : IDailySessionsService<GeneralResponse>
    {
        private readonly IUnitOfWork<DailySessions_Record> dailySessions_RecordRepository;
        public DailySessionsService(IUnitOfWork<DailySessions_Record> dailySessions_RecordRepository)
        {
            this.dailySessions_RecordRepository = dailySessions_RecordRepository;
        }

        public async Task<GeneralResponse> AddDailySessions(AddDailySessionsRequste requste)
        {
            GeneralResponse response;
            try
            {
                var DailySessions_Records = dailySessions_RecordRepository.GetAll()
                    .Include(s => s.Sessions_Record)
                    .ToList();
                foreach (var item in requste.DailySessionList)
                {
                    var Sessions_Record = DailySessions_Records
                        .Find(d => d.Id == item.Sessions_RecordId)?.Sessions_Record;
                    await dailySessions_RecordRepository.Create(new DailySessions_Record()
                    {
                        Date = item.Date,
                        Sessions_Record = Sessions_Record,
                        Subject_Title = item.Subject_Title
                    });
                }
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Daily Sessions Added Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllDailySessions(Guid divissionId)
        {
            var Data = new GetAllDailySessionsResponse();
            GeneralResponse response;
            try
            {
                var DailySessions = dailySessions_RecordRepository.GetAll()                    
                    .Include(s => s.Sessions_Record)                    
                    .Include(h => h.Sessions_Record.Hall)
                    .Include(s => s.Sessions_Record.Subject)
                    .Include(c => c.Sessions_Record._Class)
                    .Where(s => s.Sessions_Record.Division.Id == divissionId)
                    .ToList();
                foreach (var item in DailySessions)
                {
                    var Sessions_Record = DailySessions
                        .Find(c => c.Sessions_Record.Id == item.Sessions_Record.Id)
                        ?.Sessions_Record;
                    var Class = Sessions_Record?._Class;
                    var Hall = Sessions_Record?.Hall;
                    var Subject = Sessions_Record?.Subject;
                    Data.dailySessions_Records.Add(new DailySessions_RecordDto()
                    {
                        Id = item.Id,
                        Date = item.Date,
                        Subject_Title = item.Subject_Title,
                        Class = Class.Name,
                        Hall = Hall.Name,
                        SubjectName = Subject.Name,
                        Day = Sessions_Record.day.ToString(),
                    });
                }
                if (Data.dailySessions_Records.Count != 0)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Daily Sessions Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Daily Sessions Found !!";
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

        public async Task<GeneralResponse> GetAllDailySessionsByDate(GetAllDailySessionsByDateRequste requste)
        {            
            var Data = new GetAllDailySessionsByDateResponse();
            GeneralResponse response;
            try
            {
                var DailySessions = dailySessions_RecordRepository.GetAll()
                    .Include(s => s.Sessions_Record)
                    .Include(h => h.Sessions_Record.Hall)
                    .Include(s => s.Sessions_Record.Subject)
                    .Include(c => c.Sessions_Record._Class)
                    .Where(s => s.Sessions_Record.Division.Id == requste.DivisionId
                             && s.Date == requste.Date)
                    .ToList();
                foreach (var item in DailySessions)
                {
                    var Sessions_Record = DailySessions
                        .Find(c => c.Sessions_Record.Id == item.Sessions_Record.Id)
                        ?.Sessions_Record;
                    var Class = Sessions_Record?._Class;
                    var Hall = Sessions_Record?.Hall;
                    var Subject = Sessions_Record?.Subject;
                    Data.dailySessions_Records.Add(new DailySessions_RecordDto()
                    {
                        Id = item.Id,
                        Date = item.Date,
                        Subject_Title = item.Subject_Title,
                        Class = Class.Name,
                        Hall = Hall.Name,
                        SubjectName = Subject.Name,
                        Day = Sessions_Record.day.ToString(),
                    });
                }
                if (Data.dailySessions_Records.Count != 0)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Daily Sessions Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Daily Sessions Found !!";
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
