using Daihoc_FPT_News.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daihoc_FPT_News.Repository
{
    public class PostLayoutRepository : IPostLayoutRepository
    {
        DaihocFPTNewsContext db;
        public PostLayoutRepository(DaihocFPTNewsContext _db)
        {
            db = _db;
        }
        public async Task<List<PostLayout>> List()
        {
            return await db.PostLayouts.Where(x => x.Active == 1).ToListAsync();
        }
    }
}
