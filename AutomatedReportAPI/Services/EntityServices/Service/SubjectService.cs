using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class SubjectService : ISubjectService<GeneralResponse>
    {       

        public Task<GeneralResponse> GetAllSubjects(Guid divisionId)
        {
            throw new NotImplementedException();
        }
    }
}
