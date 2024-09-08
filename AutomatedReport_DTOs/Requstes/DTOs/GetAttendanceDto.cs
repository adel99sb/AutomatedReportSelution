namespace AutomatedReportCore.Requstes.DTOs
{
    public class GetAttendanceDto
    {
        public bool IsAttend { get; set; }
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Id { get; set; }
    }
}
