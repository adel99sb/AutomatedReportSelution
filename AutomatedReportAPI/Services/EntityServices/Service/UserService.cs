using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;
using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class UserService : IUserService<GeneralResponse>
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<GeneralResponse> EditeUserPassword(EditeUserPasswordRequste request)
        {
            GeneralResponse response;
            try
            {
                var user = await userRepository.GetById(request.Id);

                if (user != null)
                {
                    user.Password = request.NewPassword;
                    await userRepository.Update(user);

                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.Accepted;
                    response.Message = "User Password Edited Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "User Not Found !!";
                }
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.InternalServerError;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> GetAllUsers()
        {
            var usersDto = new List<UserDto>();
            GeneralResponse response;
            try
            {
                var users = userRepository.GetAll();
                foreach (var user in users)
                {
                    usersDto.Add(new UserDto()
                    {
                        Id = user.Id,
                        Type = user.Type
                    });
                }
                if (usersDto.Count != 0)
                {
                    response = new GeneralResponse(usersDto);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Get Users Succesfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "NO Users Found !!";
                }
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.InternalServerError;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<GeneralResponse> Login(LoginRequste request)
        {
            var userDto = new UserDto();
            GeneralResponse response;
            try
            {
                var users = userRepository.GetAll();
                foreach (var user in users)
                {
                    if (user.Type == request.UserType && user.Password == request.Password)
                    {
                        userDto.Id = user.Id;
                        userDto.Type = user.Type;
                        break; // Exit the loop once a matching user is found
                    }
                }
                if (userDto.Type != null)
                {
                    response = new GeneralResponse(userDto);
                    response.StatusCode = Requests_Status.Ok;
                    response.Message = "Login Successfully";
                }
                else
                {
                    response = new GeneralResponse(null);
                    response.StatusCode = Requests_Status.NotFound;
                    response.Message = "Check The User Name Or Password Then Try Again!!";
                }
            }
            catch (Exception ex)
            {
                response = new GeneralResponse(null);
                response.StatusCode = Requests_Status.InternalServerError;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
