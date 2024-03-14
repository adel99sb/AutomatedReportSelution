using System.Text.Json;

namespace AutomatedReportDashboard.Data
{
    public static class Helper
    {
        public static Guid UserId { get; set; } /*= new Guid("10f3562f-1a07-4dab-a16b-8b64855df56d");*/
        public static T ToObj<T>(this object data)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var Result = JsonSerializer.Deserialize<T>(data.ToString(), options);
            return Result;
        }        
        public static bool IsManager()
        {
            var ManagerId = new Guid("10f3562f-1a07-4dab-a16b-8b64855df56d");
            if (UserId == ManagerId)
                return true;
            return false;
        }
    }
}
