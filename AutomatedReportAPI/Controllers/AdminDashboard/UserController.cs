using AutomatedReport_Core.DTO_s.AdminDashboard.Responces;
using AutomatedReport_DTOs;
using AutomatedReport_DTOs.AdminDashboard.Requstes;
using AutomatedReportAPI.Infrastructure.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpGet("Login")]
        public async Task<IActionResult> Login([FromQuery] LoginRequste requste)
        {
            var users = userRepository.GetAll();
            var userDto = new UserDto();
            LoginResponse response;

            foreach (var user in users)
            {
                if (user.Type == requste.UserType && user.Password == requste.Password)
                {
                    userDto.Id = user.Id;
                    userDto.Type = user.Type;
                    response = new LoginResponse(userDto);
                    response.Message = "Login Succesfully";
                    return Ok(response);
                }
                else
                {
                    response = new LoginResponse(null);
                    response.Message = "Check The User Name Or Passwrod Then Try Again !!";
                    return BadRequest(response);
                }
            }
            return BadRequest();
        }
        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var users = userRepository.GetAll();
            var usersDto = new List<UsersDto>();
            GetUsersResponse response;

            foreach (var user in users)
            {
                usersDto.Add(new UsersDto()
                {
                    Id = user.Id,
                    Type = user.Type,
                    Password = user.Password
                });                                                  
            }
            response = new GetUsersResponse(usersDto);
            response.Message = "Get Users Succesfully";
            return Ok(response);
        }
        [HttpPut("EditeUserPassword")]
        public async Task<IActionResult> EditeUserPassword([FromQuery] EditeUserPasswordRequste requste)
        {
            var user = await userRepository.GetById(requste.Id);
            GeneralResponse response = new GeneralResponse(null);
            
            if (user != null)
            {
                user.Password = requste.NewPassword;
                await userRepository.Update(user);
                response.Message = "User Password Edited Succesfully";
                return Ok(response);
            }
            else
            {
                response.Message = "User Not Found !!";
                return BadRequest(response);
            }
        }
    }
}
