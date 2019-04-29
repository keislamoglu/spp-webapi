using System;
using System.Collections.Generic;
using DAL.Repo;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class SessionController : Controller
    {
        private readonly SessionRepo _sessionRepo;

        public SessionController(SessionRepo sessionRepo)
        {
            _sessionRepo = sessionRepo;
        }
        
        // GET api/session
        [HttpGet]
        public IEnumerable<Session> Get()
        {
            return _sessionRepo.GetAll();
        }
        
        // GET api/session/5
        [HttpGet("{id}")]
        public Session Get(Guid id)
        {
            return _sessionRepo.GetById(id);
        }
        
        // POST api/session
        [HttpPost]
        public Session Post([FromBody] Session session)
        {
            return _sessionRepo.Create(session);
        }

        // PUT api/session/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Session session)
        {
            _sessionRepo.Update(id, session);            
        }
    }
}