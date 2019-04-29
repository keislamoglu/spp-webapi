using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class VoteRepo : BaseRepo<Vote, Guid>
    {
        protected override DbSet<Vote> EntityDbSet => DbContext.Votes;

        public IEnumerable<Vote> GetByStory(Guid storyId)
        {
            return EntityDbSet.Where(t => t.StoryId == storyId).AsEnumerable();
        }

        public Vote GetByCriteria(Guid storyId, Guid voterId)
        {
            return EntityDbSet.SingleOrDefault(t => t.StoryId == storyId && t.VoterId == voterId);
        }
    }
}