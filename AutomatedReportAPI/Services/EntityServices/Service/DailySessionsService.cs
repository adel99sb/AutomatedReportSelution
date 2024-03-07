using AutomatedReportAPI.AppData.Models;
using AutomatedReportAPI.Infrastructure;
using AutomatedReportAPI.Services.EntityServices.Contracts;
using AutomatedReportCore.Requstes.AdminDashboard;
using AutomatedReportCore.Responces;

namespace AutomatedReportAPI.Services.EntityServices.Service
{
    public class DailySessionsService : IDailySessionsService<GeneralResponse>
    {
        private readonly IUnitOfWork<DailySessions_Record> dailySessions_RecordRepository;
        //private readonly ISessions_RecordRepository sessions_RecordRepository;
        public DailySessionsService(IUnitOfWork<DailySessions_Record> dailySessions_RecordRepository//,
           /* ISessions_RecordRepository sessions_RecordRepository*/)
        {
            this.dailySessions_RecordRepository = dailySessions_RecordRepository;
            //this.sessions_RecordRepository = sessions_RecordRepository;
        }

        public async Task<GeneralResponse> AddDailySessions(AddDailySessionsRequste requste)
        {
            throw new NotImplementedException();
            //GeneralResponse response;
            //try
            //{
            //    var Sessions_Records = sessions_RecordRepository.GetAll().ToList();
            //    foreach (var item in requste.DailySessionList)
            //    {
            //        var Sessions_Record = Sessions_Records
            //            .Find(d => d.Id == item.Sessions_RecordId);
            //        await dailySessions_RecordRepository.Create(new DailySessions_Record()
            //        {
            //            Date = item.Date,
            //            Sessions_Record = Sessions_Record,
            //            Subject_Title = item.Subject_Title
            //        });
            //    }
            //    response = new GeneralResponse(null);
            //    response.StatusCode = Requests_Status.Accepted;
            //    response.Message = "Daily Sessions Added Succesfully";
            //}
            //catch (Exception ex)
            //{

            //    response = new GeneralResponse(null);
            //    response.StatusCode = Requests_Status.BadRequest;
            //    response.Message = ex.Message;
            //}
            //return response;
        }

        public Task<GeneralResponse> GetAllDailySessions(Guid divissionId)
        {
            //var Data = new GetAllDailySessionsResponse();
            //GeneralResponse response;
            //try
            //{
            //    var DailySessions = dailySessions_RecordRepository.GetAll();
            //    foreach (var item in DailySessions)
            //    {
            //        Data.dailySessions_Records.Add(new DailySessions_RecordDto()
            //        {
                        
            //        })
            //    }                
            //}
            //catch (Exception ex)
            //{
            //    response = new GeneralResponse(null);
            //    response.StatusCode = Requests_Status.BadRequest;
            //    response.Message = ex.Message;
            //}
            throw new NotImplementedException();
        }

        public async Task<GeneralResponse> GetAllDailySessionsByDate(GetAllDailySessionsByDateRequste requste)
        {
            throw new NotImplementedException();
        }
    }
}
