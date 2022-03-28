
using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class SubcribeRepository : ISubcribeRepository
    {
        DaihocFPTNewsContext db;
        public SubcribeRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }


        public async Task<List<Subcribe>> List()
        {
            if (db != null)
            {
                return await db.Subcribes.Where(p => p.Active == 1).ToListAsync();
            } 
            return null;
        }
          
        public async Task<List<Subcribe>> Search(string keyword)
        {
            if (db != null)
            {
                return await db.Subcribes.Where(p => (p.Active == 1 && p.Name.Contains(keyword))).ToListAsync();
            }

            return null;
        }


        public async Task<List<Subcribe>> ListPaging(int pageIndex, int pageSize)
        {
            int offSet = 0;
            offSet = (pageIndex - 1) * pageSize;
            if (db != null)
            {
                return await (
                    from row in db.Subcribes
                    where (row.Active == 1)
                    orderby row.Id descending
                    select row
                ).Skip(offSet).Take(pageSize).ToListAsync();
            }

            return null;
        }


        public async Task<List<Subcribe>> Detail(int? id)
        {
            if (db != null)
            {
                return await db.Subcribes.Where(p => p.Id== id && p.Active == 1).ToListAsync();
            }

            return null;
        }


        public async Task<Subcribe> Add(Subcribe obj)
        {
            if (db != null)
            {
                await db.Subcribes.AddAsync(obj);
                await db.SaveChangesAsync();

                return obj;
            }

            return null;
        }


        public async Task Update(Subcribe obj)
        {
            if (db != null)
            {
                //Update that object
                db.Subcribes.Attach(obj); 
                db.Entry(obj).Property(x => x.Active).IsModified = true; 
                db.Entry(obj).Property(x => x.Name).IsModified = true;
                //db.Entry(obj).Property(x => x.Name2).IsModified = true;
                db.Entry(obj).Property(x => x.Description).IsModified = true; 
                //db.Entry(obj).Property(x => x.Url2).IsModified = true;
                //db.Entry(obj).Property(x => x.CreatedTime).IsModified = true;

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }


        public async Task Delete(Subcribe obj)
        {
            if (db != null)
            {
                //Update that obj
                db.Subcribes.Attach(obj);
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
                var obj = await db.Subcribes.FirstOrDefaultAsync(x => x.Id == objId);

                if (obj != null)
                {
                    //Delete that obj
                    db.Subcribes.Remove(obj);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }
    }
}

