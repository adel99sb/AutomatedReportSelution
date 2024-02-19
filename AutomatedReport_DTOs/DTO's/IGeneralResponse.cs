using AutomatedReportCore.Enums;

namespace AutomatedReport_DTOs
{
    public interface IGeneralResponse
    {
        public string Message { get; set; }
        public Requests_Status StatusCode { get; set; }
        public object Data { get; }

    }
}
