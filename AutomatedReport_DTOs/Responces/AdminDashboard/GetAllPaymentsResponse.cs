using AutomatedReportCore.Responces.DTOs;

namespace AutomatedReportCore.Responces.AdminDashboard
{
    public class GetAllPaymentsResponse
    {
        public List<PaymentDto> payments { get; set; } = new();
        public double Sum
        { private set
            {
                foreach (var item in payments)
                {
                    value += item.Value;
                }
            }
            get
            {
                return Sum;
            }
        }        
    }    
}
