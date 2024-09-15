namespace AutomatedReportAPI.Services.EntityServices.Contracts
{
    public interface IStatisticsService<T>
    {
        Task<T> GetAll();
    }
}
