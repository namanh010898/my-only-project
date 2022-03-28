
    using Daihoc_FPT_News.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace Daihoc_FPT_News.Repository
    {
        public interface ISubcribeRepository
        {
            Task<List<Subcribe>> List(); 
            

            Task<List<Subcribe>> Search(string keyword);

            Task<List<Subcribe>> ListPaging(int pageIndex, int pageSize);

            Task<List<Subcribe>> Detail(int? postId);

            Task<Subcribe> Add(Subcribe Subcribe);

            Task Update(Subcribe Subcribe);

            Task Delete(Subcribe Subcribe);

            Task<int> DeletePermanently(int? SubcribeId);
        }
    }
    