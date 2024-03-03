using AutomatedReport_DTOs.AdminDashboard.Requstes;
using AutomatedReportAPI.AppData.Models;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface IDivisionService<T>
    {
        Task<T> AddDivision(AddDivisionRequste requste);
        Task<T> GetAllDivisionsWithStudentsNomber(Guid certificateId);
        Task<T> GetDivisionById(Guid id);
        Task<T> EditeDivision(EditeDivisionRequste requste);
        Task<T> DeleteDivision(Guid id);
        Task<T> GetAllDivisions(Guid? certificateId);
    }
}
