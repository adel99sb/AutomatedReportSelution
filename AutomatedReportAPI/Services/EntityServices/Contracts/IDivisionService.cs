using AutomatedReport_DTOs.AdminDashboard.Requstes;

namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface IDivisionService<T>
    {
        Task<T> AddDivision(AddDivisionRequste requste);
        Task<T> EditeDivision(EditeDivisionRequste requste);
        Task<T> GetAllDivisiones();
        Task<T> DeleteDivisione(Guid id);
        Task<T> GetDivisioneById(Guid id);
        Task<T> GetDivisionsByCertificateName(string certificateName);
    }
}
