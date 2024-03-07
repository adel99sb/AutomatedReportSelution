namespace AutomatedReportCore.Responces.DTOs
{
    public class StudentDto : StudentAttendanceDto
    {
        public string Gender { get; set; }
        public string? Address { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Parent_Name { get; set; }
        public string Parent_Phone { get; set; }
        public double Total_Payments { get; set; }
        public string Division { get; set; }
    }
}
