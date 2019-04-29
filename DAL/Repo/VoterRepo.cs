using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class VoterRepo : BaseRepo<Voter, Guid>
    {
        protected override DbSet<Voter> EntityDbSet => DbContext.Voters;

        public IEnumerable<Voter> GetBySession(Guid sessionId)
        {
            return EntityDbSet.Where(t => t.SessionId == sessionId).AsEnumerable();
        }
    }
}