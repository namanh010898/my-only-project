
using Daihoc_FPT_News.Models;
//using Daihoc_FPT_News.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public interface ICommentRepository
    {
        Task<List<Comment>> List();
        Task<List<Comment>> ListCommentAdmin();

        Task<List<Comment>> Search(string keyword);

        Task<List<Comment>> ListPaging(int pageIndex, int pageSize);
        Task<List<Comment>> ListPagingPost(int PostID, int pageIndex, int pageSize);
        Task<List<Comment>> ListPagingUser(int UserID, int pageIndex, int pageSize);

        Task<List<Comment>> Detail(int? postId);

        Task<Comment> Add(Comment Comment);

        Task Update(Comment Comment);

        Task Delete(Comment Comment);

        Task<int> DeletePermanently(int? CommentId);

        int CountCommentUnChecked();
    }
}
