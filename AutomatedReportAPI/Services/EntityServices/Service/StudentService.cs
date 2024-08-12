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
    public class StudentService : IStudentService<GeneralResponse>
    {
        private readonly IUnitOfWork<Student> studentRepository;
        private readonly IUnitOfWork<Test_Mark> testMarkRepository;
        private readonly IUnitOfWork<Division> divisionMarkRepository;
        public StudentService(IUnitOfWork<Student> studentRepository,
            IUnitOfWork<Test_Mark> testMarkRepository,
            IUnitOfWork<Division> divisionMarkRepository)
        {
            this.studentRepository = studentRepository;
            this.testMarkRepository = testMarkRepository;
            this.divisionMarkRepository = divisionMarkRepository;
        }

        public async Task<GeneralResponse> AddStudent(AddStudentRequste requste)
        {
            GeneralResponse response;
            try
            {
                var divison = divisionMarkRepository.GetAll()                    
                    .Where(d => d.Id == requste.divisionId)
                    ?.FirstOrDefault();
                await studentRepository.Create(new Student()
                {
                    First_Name = requste.first_Name,
                    Last_Name = requste.last_Name,
                    Address = requste.address,
                    BirthDay = requste.birthDay,
                    Gender = requste.gender,
                    Parent_Name = requste.parent_Name,
                    Parent_Phone = requste.parent_Phone,
                    Phone = requste.phone,
                    Total_Payments = requste.total_Payments,
                    DivisionId = requste.divisionId
                });

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Student Added Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> DeleteStudent(Guid id)
        {
            GeneralResponse response;
            try
            {
                await studentRepository.Delete(id);

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Student Deleted Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> EditeStudent(EditeStudentRequste requste)
        {
            GeneralResponse response;
            try
            {
                var divison = studentRepository.GetAll()
                    .Include(d => d.Division)
                    .Where(d => d.Division.Id == requste.divisionId)
                    .FirstOrDefault()?.Division;
                await studentRepository.Update(new Student()
                {
                    Id = requste.id,
                    First_Name = requste.first_Name,
                    Last_Name = requste.last_Name,
                    Address = requste.address,
                    BirthDay = requste.birthDay,
                    Gender = requste.gender,
                    Parent_Name = requste.parent_Name,
                    Parent_Phone = requste.parent_Phone,
                    Phone = requste.phone,
                    Total_Payments = requste.total_Payments,
                    Division = divison
                });

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.Accepted;
                response.Message = "Student Updated Succesfully";
            }
            catch (Exception ex)
            {

                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.BadRequest;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllStudentsByDivisionId(Guid divisionId)
        {
            var Data = new GetAllStudentsByDivisionIdResponse();
            GeneralResponse response;
            try
            {
                var Students = studentRepository.GetAll()
                    .Include(d => d.Division)
                    .Where(d => d.Division.Id == divisionId);
                foreach (var item in Students)
                {
                    Data.students.Add(new StudentAttendanceDto()
                    {
                        Id = item.Id,
                        First_Name = item.First_Name,
                        Last_Name = item.Last_Name
                    });
                }
                if (Data.students.Count != 0)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Students Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Students Found !!";
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

        public async Task<GeneralResponse> GetAllStudentsByTestId(Guid testId)
        {
            var Data = new GetAllStudentsByTestIdResponse();
            GeneralResponse response;
            try
            {
                var StudentsId = testMarkRepository.GetAll()
                    .Include(t => t.Test)
                    .Include(s => s.Student)
                    .Where(t => t.Test.Id == testId)
                    .Select(s => s.Student.Id).ToList();
                    Data.studebtsIds.AddRange(StudentsId);
                if (Data.studebtsIds.Count != 0)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Students Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Students Found !!";
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

        public async Task<GeneralResponse> GetAllStudentsWithDivision()
        {
            var Data = new GetAllStudentsWithDivisionResponse();
            GeneralResponse response;
            try
            {
                var Students = studentRepository.GetAll()
                    .Include(d => d.Division);
                foreach (var item in Students)
                {
                    Data.students.Add(new StudentDto()
                    {
                        Id = item.Id,
                        First_Name = item.First_Name,
                        Last_Name = item.Last_Name,
                        Address = item.Address,
                        BirthDay = item.BirthDay,
                        Gender = item.Gender,
                        Parent_Name = item.Parent_Name,
                        Parent_Phone = item.Parent_Phone,
                        Phone = item.Phone,
                        Total_Payments = item.Total_Payments,
                        Division = item.Division.Name
                    });
                }
                if (Data.students.Count != 0)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Students Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Students Found !!";
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

        public async Task<GeneralResponse> GetStudentById(Guid id)
        {
            var Data = new GetStudentByIdResponse();
            GeneralResponse response;
            try
            {
                var Student = studentRepository.GetAll()
                    .Include(d => d.Division)
                    .Where(s => s.Id == id).FirstOrDefault();
               Data.student =  new StudentDto()
                    {
                        Id = Student.Id,
                        First_Name = Student.First_Name,
                        Last_Name = Student.Last_Name,
                        Address = Student.Address,
                        BirthDay = Student.BirthDay,
                        Gender = Student.Gender,
                        Parent_Name = Student.Parent_Name,
                        Parent_Phone = Student.Parent_Phone,
                        Phone = Student.Phone,
                        Total_Payments = Student.Total_Payments,
                        Division = Student.Division.Name
                    };                
                if (Student is not null)
                {
                    response = new GeneralResponse(Data);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Student Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "No Students Found !!";
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
