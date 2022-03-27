
using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class ViewStatusRepository : IViewStatusRepository
    {
        DaihocFPTNewsContext db;
        public ViewStatusRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }


        public async Task<List<ViewStatus>> List()
        {
            if (db != null)
            {
                //return await (
                //    from row in db.ViewStatuses
                //    where (row.Active == 1)
                //    orderby row.Id ascending
                //    select row
                //).ToListAsync();

                return await db.ViewStatuses.Where(p => p.Active == 1).ToListAsync();
            } 
            return null;
        }
         

        public async Task<List<ViewStatus>> Search(string keyword)
        {
            if (db != null)
            {
                return await db.ViewStatuses.Where(p => p.Active == 1 && (p.Description.Contains(keyword) || p.Name.Contains(keyword)) ).ToListAsync();
                //return await (
                //    from row in db.ViewStatuses
                //    where (row.Active == 1 && (row.Name.Contains(keyword) || row.Description.Contains(keyword)))
                //    orderby row.Id descending
                //    select row
                //).ToListAsync();
            }

            return null;
        }


        public async Task<List<ViewStatus>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;

            if (db != null)
                return await db.ViewStatuses.Where(p => p.Active == 1).Skip(offSet).Take(pageSize).ToListAsync();

            //if (db != null)
            //{
            //    return await (
            //        from row in db.Menu
            //        where (row.Active == 1)
            //        orderby row.Id descending
            //        select row
            //    ).Skip(offSet).Take(pageSize).ToListAsync();
            //}

            return null;
        }


        public async Task<List<ViewStatus>> Detail(int? id)
        {
            if (db != null)
            {
                return await db.ViewStatuses.Where(p => p.Active == 1 && p.Id == id).ToListAsync();
            }

            return null;
        }


        public async Task<ViewStatus> Add(ViewStatus obj)
        {
            if (db != null)
            {
                await db.ViewStatuses.AddAsync(obj);
                await db.SaveChangesAsync();

                return obj;
            } 
            return null;
        }


        public async Task Update(ViewStatus obj)
        {
            if (db != null)
            {
                //Update that object
                db.ViewStatuses.Attach(obj); 
                db.Entry(obj).Property(x => x.Active).IsModified = true; 
                db.Entry(obj).Property(x => x.Name).IsModified = true; 
                db.Entry(obj).Property(x => x.Description).IsModified = true;  

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }


        public async Task Delete(ViewStatus obj)
        {
            if (db != null)
            {
                //Update that obj
                db.ViewStatuses.Attach(obj);
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
                var obj = await db.ViewStatuses.FirstOrDefaultAsync(x => x.Id == objId);

                if (obj != null)
                {
                    //Delete that obj
                    db.ViewStatuses.Remove(obj);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }
    }
}

