using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class ContactRepository : IContactRepository
    {
        DaihocFPTNewsContext db;
        public ContactRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }
        public async Task<Contact> Add(Contact Contact)
        {
            if(db != null)
            {
                await db.AddAsync(Contact);
                await db.SaveChangesAsync();

                return Contact;
            }

            return null;

        }

        public int CountContact()
        {
            return db.Contacts.ToList().Count();
        }

        public async Task Delete(Contact Contact)
        {
            if(db != null)
            {
                db.Attach(Contact);
                db.Entry(Contact).Property(x => x.Active).IsModified = true;
                await db.SaveChangesAsync();
            }
        }

        public async Task<int> DeletePermanently(int? ContactId)
        {
            int result = 0;
            if(db != null)
            {
                var obj = await db.Contacts.FirstOrDefaultAsync(x => x.Id == ContactId);
                if(obj != null)
                {
                    db.Contacts.Remove(obj);
                    result = await db.SaveChangesAsync();
                }
                return result;
            }
            return result;
        }

        public async Task<List<Contact>> Detail(int? Id)
        {
            return await db.Contacts.Where(x => x.Id == Id).ToListAsync();
        }

        public async Task<List<Contact>> List()
        {
            if(db != null)
            {
                return await db.Contacts.Where(x => x.Active == 1).ToListAsync();
            }
            return null;
        }

        public async Task<List<Contact>> ListPaging(int pageIndex, int pageSize)
        {
            int offset = 0;
            offset = (pageIndex - 1) * pageSize;
            if(db != null)
            {
                return await db.Contacts.Skip(offset).Take(pageSize).ToListAsync();
            }
            return null;
        }

        public async Task<List<Contact>> Search(string keyword)
        {
            // search đối chiếu keyword với name hoặc description
            if(db != null)
            {
                return await db.Contacts.Where(x => x.Name == keyword || x.Description == keyword).ToListAsync();
            }
            return null;
        }

        public async Task Update(Contact Contact)
        {
            if(db != null)
            {
                db.Attach(Contact);
                db.Entry(Contact).Property(x => x.Name).IsModified = true;
                db.Entry(Contact).Property(x => x.Email).IsModified = true;
                db.Entry(Contact).Property(x => x.Phone).IsModified = true;
                db.Entry(Contact).Property(x => x.Description).IsModified = true;
                //db.Entry(Contact).Property(x => x.CompanyName).IsModified = true;
                //db.Entry(Contact).Property(x => x.CompanyNumber).IsModified = true;
                db.Entry(Contact).Property(x => x.CreatedTime).IsModified = true;
                await db.SaveChangesAsync();
            }
        }
    }
}
