using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class StoryRepo : BaseRepo<Story, Guid>
    {
        protected override DbSet<Story> EntityDbSet => DbContext.Stories;

        public IEnumerable<Story> GetBySession(Guid sessionId)
        {
            return EntityDbSet.Where(t => t.SessionId == sessionId).AsEnumerable();
        }
    }
}