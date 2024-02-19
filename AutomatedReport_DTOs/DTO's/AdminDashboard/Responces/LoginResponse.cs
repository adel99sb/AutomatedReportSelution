using AutomatedReport_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReport_Core.DTO_s.AdminDashboard.Responces
{
    public class LoginResponse : GeneralResponse,IGeneralResponse
    {
        public LoginResponse(UserDto user) : base(user) { }
    }
}
