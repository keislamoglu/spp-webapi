using System;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo
{
    public class SessionRepo : BaseRepo<Session, Guid>
    {
        protected override DbSet<Session> EntityDbSet => DbContext.Sessions;
    }
}