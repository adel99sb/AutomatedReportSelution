using AutomatedReportCore.Responces;
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
            baseUrl = "http://localhost:5000/";
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
        public async Task<GeneralResponse> GetAllDivisionsWithStudentsNomber(Guid Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl+$"api/Division/GetAllDivisionsWithStudentsNomber?certificateId={Id}");
            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            GeneralResponse Data = JsonSerializer.Deserialize<GeneralResponse>(result, options);
            return Data;
        }
    }
}
