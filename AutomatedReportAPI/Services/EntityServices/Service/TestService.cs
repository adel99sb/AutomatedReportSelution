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
    public class TestService : ITestService<GeneralResponse>
    {
        private readonly IUnitOfWork<Test> testRepository;
        public TestService(IUnitOfWork<Test> testRepository)
        {
            this.testRepository = testRepository;
        }

        public async Task<GeneralResponse> AddTest(AddTestRequste requste)
        {
            GeneralResponse response;
            try
            {
                var Tests = testRepository.GetAll()
                    .Include(d => d.Division)
                    .Include(s => s.Subject)
                    .ToList();
                var division = Tests.Find(d => d.Division.Id == requste.DivisionId)?
                    .Division;
                var subject = Tests.Find(s => s.Subject.Id == requste.SubjectId)?
                    .Subject;
                await testRepository.Create(new Test()
                {
                    DateTime = requste.DateTime,
                    Description = requste.Description,
                    IsDone = false,
                    TotalMark = requste.TotalMark,
                    Division = division,
                    Subject = subject
                });

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Test Added Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> DeleteTest(Guid id)
        {
            GeneralResponse response;
            try
            {
                await testRepository.Delete(id);

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Test Deleted Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> EditeTest(EditeTestRequste requste)
        {
            GeneralResponse response;
            try
            {
                var Tests = testRepository.GetAll()
                    .Include(d => d.Division)
                    .Include(s => s.Subject)
                    .ToList();
                var division = Tests.Find(d => d.Division.Id == requste.DivisionId)?
                    .Division;
                var subject = Tests.Find(s => s.Subject.Id == requste.SubjectId)?
                    .Subject;
                await testRepository.Update(new Test()
                {
                    Id = requste.Id,
                    DateTime = requste.DateTime,
                    Description = requste.Description,
                    IsDone = false,
                    TotalMark = requste.TotalMark,
                    Division = division,
                    Subject = subject
                });

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Test Updated Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllTests(Guid divisionId)
        {
            var Data = new GetAllTestsResponse();
            GeneralResponse response;
            try
            {
                var Tests = testRepository.GetAll()
                    .Include(s => s.Subject);
                if (Tests.Count() != 0)
                {
                    foreach (var item in Tests)
                    {
                        Data.tests.Add(new TestDto()
                        {
                            Id = item.Id,
                            DateTime = item.DateTime,
                            Description = item.Description,
                            IsDone = item.IsDone,
                            TotalMark = item.TotalMark,
                            Subject = item.Subject.Name
                        });
                    }
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Tests Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Tests Found !!";
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

        public async Task<GeneralResponse> GetTestById(Guid id)
        {
            var Data = new GetTestByIdResponse();
            GeneralResponse response;
            try
            {
                var test = testRepository.GetAll()
                    .Include(s => s.Subject)
                    .Where(t => t.Id == id).FirstOrDefault();                    
                if (test is not null)
                {
                    Data.test = new TestDto()
                    {
                        Id = test.Id,
                        DateTime = test.DateTime,
                        Subject = test.Subject.Name,
                        Description = test.Description,
                        TotalMark = test.TotalMark,
                        IsDone = test.IsDone
                    };
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Test Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Test Found !!";
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

        public async Task<GeneralResponse> MarkAsDone(Guid id)
        {
            GeneralResponse response;
            try
            {               
                await testRepository.Update(new Test()
                {
                    Id = id,
                    IsDone = false,
                });

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Test Updated Succesfully";
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
