using AutomatedReport_DTOs;
using AutomatedReport_DTOs.AdminDashboard.Requstes;
using AutomatedReportAPI.Services;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AutomatedReportAPI.Controllers.AdminDashboard
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class UserController : ControllerBase , IUserService<IActionResult>
    {
        private readonly IUserService<IGeneralResponse> userService;
        public UserController(IUserService<IGeneralResponse> userService)
        {
            this.userService = userService;
        }
        [HttpGet("Login")]
        public async Task<IActionResult> Login([Required][FromQuery] LoginRequste request)
        {
            try
            {
                var Result = await userService.Login(request);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }
        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var Result = await userService.GetUsers();
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("EditeUserPassword")]
        public async Task<IActionResult> EditeUserPassword([Required][FromQuery] EditeUserPasswordRequste request)
        {
            try
            {
                var Result = await userService.EditeUserPassword(request);
                var Response = Result.StatusCode.ToActionResult(Result);
                return Response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }        
    }
}
