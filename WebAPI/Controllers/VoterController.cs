using System;
using System.Collections.Generic;
using DAL.Repo;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class VoterController : Controller
    {
        private readonly VoterRepo _voterRepo;

        public VoterController(VoterRepo voterRepo)
        {
            _voterRepo = voterRepo;
        }
        
        // GET api/voter
        [HttpGet]
        public IEnumerable<Voter> Get()
        {
            return _voterRepo.GetAll();
        }
        
        // GET api/voter/5
        [HttpGet("{id}")]
        public Voter Get(Guid id)
        {
            return _voterRepo.GetById(id);
        }

        // GET api/voter/by-session/2
        [HttpGet("by-session/{sessionId}")]
        public IEnumerable<Voter> GetBySession(Guid sessionId)
        {
            return _voterRepo.GetBySession(sessionId);
        }
        
        // POST api/voter
        [HttpPost]
        public Voter Post([FromBody] Voter voter)
        {
            return _voterRepo.Create(voter);
        }

        // PUT api/voter/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Voter voter)
        {
            _voterRepo.Update(id, voter);            
        }
    }
}