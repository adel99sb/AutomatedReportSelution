using AutomatedReport_Core.DTO_s.AdminDashboard.Responces;
using AutomatedReport_DTOs;
using AutomatedReport_DTOs.AdminDashboard.Requstes;
using AutomatedReportAPI.Infrastructure.Contracts;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Enums;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class UserService : IUserService<IGeneralResponse>
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<IGeneralResponse> EditeUserPassword(EditeUserPasswordRequste request)
        {
            IGeneralResponse response;
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

        public async Task<IGeneralResponse> GetUsers()
        {
            var usersDto = new List<UsersDto>();
            IGeneralResponse response;
            try
            {
                var users = userRepository.GetAll();
                foreach (var user in users)
                {
                    usersDto.Add(new UsersDto()
                    {
                        Id = user.Id,
                        Type = user.Type,
                        Password = user.Password
                    });
                }
                if (usersDto.Count != 0)
                {
                    response = new GetUsersResponse(usersDto);
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

        public async Task<IGeneralResponse> Login(LoginRequste request)
        {
            var userDto = new UserDto();
            IGeneralResponse response;
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
                    response = new LoginResponse(userDto);
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
