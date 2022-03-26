
using Daihoc_FPT_News.Models;
//using GappingWorld.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
    {
        public class EventRequestRepository : IEventRequestRepository
        {
        DaihocFPTNewsContext db;
            public EventRequestRepository(DaihocFPTNewsContext _db)
            {
                db = _db;
            }


            public async Task<List<EventRequest>> List()
            {
                if (db != null)
                {
                    try {
                        return await (
                            from row in db.EventRequests
                            join account in db.Accounts on row.AccountId equals account.Id
                            join events in db.Posts on row.PostId equals events.Id
                            where (row.Active == 1 && account.Active == 1 && events.Active == 1)
                            orderby row.Id descending
                            select row
                        ).ToListAsync();
                    } catch(Exception e){
                        string error = e.Message;
                    }
                }

                return null;
            }

        public async Task<List<EventRequest>> ListByAccountIdAndEventId(int AccountId, int EventId)
        {
            if (db != null)
            {
                try
                {
                    return await(
                    from row in db.EventRequests
                    from ac in db.Accounts
                    from p in db.Posts
                    where (
                        row.Active == 1 && ac.Active == 1 && p.Active == 1
                        && row.AccountId == AccountId
                        && row.PostId == EventId
                        && row.AccountId == ac.Id
                        && row.PostId == p.Id
                    )
                    orderby row.Id descending
                    select row
                    ).ToListAsync();
                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return null;
        }

        public async Task<List<EventRequest>> ListByAccountId(int AccountId)
        {
            if (db != null)
            {
                try
                {
                    return await (
                    from row in db.EventRequests
                    from ac in db.Accounts
                    where (
                        row.Active == 1
                        && row.AccountId == AccountId
                        && row.AccountId == ac.Id
                    )
                    orderby row.Id descending
                    select row
                    ).ToListAsync();
                }
                catch (Exception e)
                {
                    string error = e.Message;
                }
            }

            return null;
        }


        public async Task<List<EventRequest>> Search(string keyword)
            {
                if (db != null)
                {
                    
                    try {
                            return await (
                                from row in db.EventRequests
                                where (row.Active == 1 && (row.Name.Contains(keyword) || row.Description.Contains(keyword)))
                                orderby row.Id descending
                                select row
                            ).ToListAsync();

                    } catch(Exception e){
                        string error = e.Message;
                    }
                }

                return null;
            }


            public async Task<List<EventRequest>> ListPaging(int pageIndex, int pageSize)
            {
                int offSet = 0;
                offSet = (pageIndex - 1) * pageSize;
                if (db != null)
                {
                    try {
                        return await (
                            from row in db.EventRequests
                            where (row.Active == 1)
                            orderby row.Id descending
                            select row
                        ).Skip(offSet).Take(pageSize).ToListAsync();

                    } catch(Exception e){
                        string error = e.Message;
                    }
                }

                return null;
            }


            public async Task<List<EventRequest>> Detail(int? id)
            {
                if (db != null)
                {
                    try {
                        return await (
                            from row in db.EventRequests
                            where (row.Active == 1 && row.Id == id)
                            select row)
                        .ToListAsync();

                    } catch(Exception e){
                        string error = e.Message;
                    }
                }

                return null;
            }


            public async Task<EventRequest> Add(EventRequest obj)
            {
                if (db != null)
                {
                    try {
                        await db.EventRequests.AddAsync(obj);
                        await db.SaveChangesAsync();
    
                        return obj;

                    } catch(Exception e){
                        string error = e.Message;
                    }
                }

                return null;
            }


            public async Task Update(EventRequest obj)
            {
                if (db != null)
                {
                    try {
                        //Update that object
                        db.EventRequests.Attach(obj);
                        // db.Entry(obj).Property(x => x.Name).IsModified = true;
                        // db.Entry(obj).Property(x => x.Description).IsModified = true;
                        // db.Entry(obj).Property(x => x.Active).IsModified = true;
                        	db.Entry(obj).Property(x => x.PostId).IsModified = true;
	db.Entry(obj).Property(x => x.AccountId).IsModified = true;
	db.Entry(obj).Property(x => x.Active).IsModified = true;
	db.Entry(obj).Property(x => x.EventRequestStatusId).IsModified = true;
	db.Entry(obj).Property(x => x.Name).IsModified = true;
	db.Entry(obj).Property(x => x.Email).IsModified = true;
	db.Entry(obj).Property(x => x.Phone).IsModified = true;
	db.Entry(obj).Property(x => x.Description).IsModified = true;

    
                        //Commit the transaction
                        await db.SaveChangesAsync();

                    } catch(Exception e){
                        string error = e.Message;
                    }
                }
            }


            public async Task Delete(EventRequest obj)
            {
                if (db != null)
                {
                    try {
                        //Update that obj
                        db.EventRequests.Attach(obj);
                        db.Entry(obj).Property(x => x.Active).IsModified = true;
    
                        //Commit the transaction
                        await db.SaveChangesAsync();

                    } catch(Exception e){
                        string error = e.Message;
                    }
                }
            }

            public async Task<int> DeletePermanently(int? objId)
            {
                int result = 0;

                if (db != null)
                {
                    try {
                        //Find the obj for specific obj id
                        var obj = await db.EventRequests.FirstOrDefaultAsync(x => x.Id == objId);
    
                        if (obj != null)
                        {
                            //Delete that obj
                            db.EventRequests.Remove(obj);
    
                            //Commit the transaction
                            result = await db.SaveChangesAsync();
                        }
                        return result;

                    } catch(Exception e){
                        string error = e.Message;
                    }
                }

                return result;
            }


            public int CountEventRequest()
            {
                int result = 0;

                if (db != null)
                {
                    try {
                        //Find the obj for specific obj id
                        result = (
                            from row in db.EventRequests
                            where row.Active == 1
                            select row
                        ).Count();

                    } catch(Exception e){
                        string error = e.Message;
                    }
                }

                return result;
            }
        }
    }

    