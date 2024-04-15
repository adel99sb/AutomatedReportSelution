using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;
using System.Text;
using System.Text.Json;

namespace AutomatedReportDashboard.Data
{
    public class DataService
    {
        HttpClient client;
        string baseUrl;
        JsonSerializerOptions options;
        public DataService()
        {
            client = new HttpClient();
            //baseUrl = "http://localhost:5000/";
            baseUrl = "https://adel99.bsite.net/";
            options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        }
        public async Task<GeneralResponse> GetAllUsers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "api/User/GetAllUsers");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> Login(string UserId, string Password)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/User/Login?Id={UserId}&Password={Password}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> EditePassword(string UserId, string Password)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, baseUrl + $"api/User/EditeUserPassword?Id={UserId}&NewPassword={Password}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetAllCertificates()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "api/Certificate/GetAllCertificates");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetAllHalls()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "api/Hall/GetAllHalls");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetAllTeachers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "api/Teacher/GetAllTeachers");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetAllClasses()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "api/Class/GetAllClasses");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }        
        public async Task<GeneralResponse> GetAllStudentsWithDivision()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "api/Student/GetAllStudentsWithDivision");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetAllDivisionsWithStudentsNomber(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/Division/GetAllDivisionsWithStudentsNomber?certificateId={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetDivisionById(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/Division/GetDivisionById?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetAllDivisions(Guid? Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/Division/GetAllDivisions?certificateId={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetHallById(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/Hall/GetHallById?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetAllPayments(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/Payment/GetAllPayments?studentId={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetTeacherById(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/Teacher/GetTeacherById?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetStudentById(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/Student/GetStudentById?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> GetClassById(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"api/Class/GetClassById?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> DeleteDivision(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, baseUrl + $"api/Division/DeleteDivision?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;

        }
        public async Task<GeneralResponse> DeleteClass(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, baseUrl + $"api/Class/DeleteClass?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;

        }
        public async Task<GeneralResponse> DeleteTeacher(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, baseUrl + $"api/Teacher/DeleteTeacher?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;

        }
        public async Task<GeneralResponse> DeleteStudent(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, baseUrl + $"api/Student/DeleteStudent?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;

        }
        public async Task<GeneralResponse> DeleteHall(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, baseUrl + $"api/Hall/DeleteHall?id={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;

        }
        public async Task<GeneralResponse> EditeDivision(EditeDivisionRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, baseUrl + "api/Division/EditeDivision");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> EditeTeacher(EditeTeacherRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, baseUrl + "api/Teacher/EditeTeacher");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> AddTeacher(AddTeacherRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "api/Teacher/AddTeacher");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> AddClass(AddClassRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "api/Class/AddClass");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> EditeClass(EditeClassRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, baseUrl + "api/Class/EditeClass");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> EditeHall(EditeHallRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, baseUrl + "api/Hall/EditeHall");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> AddHall(AddHallRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "api/Hall/AddHall");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> AddDivision(AddDivisionRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "api/Division/AddDivision");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> AddStudent(AddStudentRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "api/Student/AddStudent");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> AddPayment(AddPaymentRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "api/Payment/AddPayment");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
        public async Task<GeneralResponse> EditeStudent(EditeStudentRequste requsteData)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, baseUrl + "api/Student/EditeStudent");
            var DataRequste = JsonSerializer.Serialize(requsteData);
            var content = new StringContent(DataRequste, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
    }
}
