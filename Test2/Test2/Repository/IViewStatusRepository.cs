
    using Daihoc_FPT_News.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace Daihoc_FPT_News.Repository
    {
        public interface IViewStatusRepository
        {
            Task<List<ViewStatus>> List(); 
            

        Task<List<ViewStatus>> Search(string keyword);

            Task<List<ViewStatus>> ListPaging(int pageIndex, int pageSize);

            Task<List<ViewStatus>> Detail(int? postId);

            Task<ViewStatus> Add(ViewStatus viewStatus);

            Task Update(ViewStatus viewStatus);

            Task Delete(ViewStatus viewStatus);

            Task<int> DeletePermanently(int? viewStatusId);
        }
    }
    