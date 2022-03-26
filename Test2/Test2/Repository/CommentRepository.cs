
using Daihoc_FPT_News.Models;
//using GappingWorld.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class CommentRepository : ICommentRepository
    {
        DaihocFPTNewsContext db;
        public CommentRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }


        public async Task<List<Comment>> List()
        {
            if (db != null)
            {
                return await db.Comments.Where(p => p.Active == 1).ToListAsync();
            }

            return null;
        }

        public async Task<List<Comment>> ListCommentAdmin()
        {
            // not validated
            if (db != null)
            {
                return await db.Comments.Where(p => p.Active == 1).ToListAsync();
            }
            return null;
        }

        public async Task<List<Comment>> Search(string keyword)
        {
            if (db != null)
            {
                return await db.Comments.Where(x => x.Name.Contains(keyword) && x.Active == 1).ToListAsync();
            } 
            return null;
        }


        public async Task<List<Comment>> ListPaging(int pageIndex, int pageSize)
        {
            // not check validate
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                return await db.Comments.Where(p => p.Active == 1).Skip(offSet).Take(pageSize).ToListAsync(); 
            }

            return null;
        }
        public async Task<List<Comment>> ListPagingPost(int PostID, int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                return await db.Comments.Where(p => p.Active == 1 && p.PostId == PostID).Skip(offSet).Take(pageSize).ToListAsync();
            }
            return null;
        }

        public async Task<List<Comment>> ListPagingUser(int UserID, int pageIndex, int pageSize)
        {
            // chua validate
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                return await db.Comments.Where(p => p.Active == 1).Skip(offSet).Take(pageSize).ToListAsync();
            }
            return null;
        }


        public async Task<List<Comment>> Detail(int? id)
        {
            if (db != null)
            {
                return await db.Comments.Where(p => p.Id == id && p.Active == 1).ToListAsync();
            }
            return null;
        }


        public async Task<Comment> Add(Comment obj)
        {
            if (db != null)
            {
                await db.Comments.AddAsync(obj);
                await db.SaveChangesAsync();

                return obj;
            }

            return null;
        }


        public async Task Update(Comment obj)
        {
            if (db != null)
            {
                //Update that object
                db.Comments.Attach(obj);
                // db.Entry(obj).Property(x => x.Name).IsModified = true;
                // db.Entry(obj).Property(x => x.Description).IsModified = true;
                // db.Entry(obj).Property(x => x.Active).IsModified = true;
                db.Entry(obj).Property(x => x.PostId).IsModified = true;
                db.Entry(obj).Property(x => x.AccountId).IsModified = true;
                db.Entry(obj).Property(x => x.Active).IsModified = true;
                db.Entry(obj).Property(x => x.Approve).IsModified = true;
                db.Entry(obj).Property(x => x.Name).IsModified = true;
                db.Entry(obj).Property(x => x.Description).IsModified = true;
                db.Entry(obj).Property(x => x.Email).IsModified = true;
                db.Entry(obj).Property(x => x.Text).IsModified = true;
                db.Entry(obj).Property(x => x.Website).IsModified = true;
                //db.Entry(obj).Property(x => x.CreatedTime).IsModified = true;
                db.Entry(obj).Property(x => x.IsChecked).IsModified = true;
                 
                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }


        public async Task Delete(Comment obj)
        {
            if (db != null)
            {
                //Update that obj
                db.Comments.Attach(obj);
                db.Entry(obj).Property(x => x.Active).IsModified = true;

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }

        public async Task<int> DeletePermanently(int? objId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the obj for specific obj id
                var obj = await db.Comments.FirstOrDefaultAsync(x => x.Id == objId);

                if (obj != null)
                {
                    //Delete that obj
                    db.Comments.Remove(obj);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public int CountCommentUnChecked()
        {
            int result = 0;

            if (db != null)
            {
                //Find the obj for specific obj id
                result = (
                    from row in db.Comments
                    where (row.Active == 1 && row.IsChecked == 0)
                    select row
                ).Count();
            }

            return result;
        }
    }
}

