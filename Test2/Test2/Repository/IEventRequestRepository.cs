
using Daihoc_FPT_News.Models;
//using Daihoc_FPT_News.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
        public interface IEventRequestRepository
        {
            Task<List<EventRequest>> List();

            Task<List<EventRequest>> Search(string keyword);

            Task<List<EventRequest>> ListPaging(int pageIndex, int pageSize);

            Task<List<EventRequest>> Detail(int? postId);

            Task<EventRequest> Add(EventRequest EventRequest);

            Task Update(EventRequest EventRequest);

            Task Delete(EventRequest EventRequest);

            Task<int> DeletePermanently(int? EventRequestId);

            int CountEventRequest();

        Task<List<EventRequest>> ListByAccountIdAndEventId(int AccountId, int EventId);

        Task<List<EventRequest>> ListByAccountId(int AccountId);
        }
    }
    