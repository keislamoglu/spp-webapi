using System;
using System.Collections.Generic;
using DAL.Repo;
using Entity;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class VoteController : Controller
    {
        private readonly VoteRepo _voteRepo;

        public VoteController(VoteRepo voteRepo)
        {
            _voteRepo = voteRepo;
        }

        // GET api/vote
        [HttpGet]
        public IEnumerable<Vote> Get()
        {
            return _voteRepo.GetAll();
        }

        // GET api/vote/5
        [HttpGet("{id}")]
        public Vote Get(Guid id)
        {
            return _voteRepo.GetById(id);
        }

        // GET api/vote/by-story/2
        [HttpGet("by-story/{storyId}")]
        public IEnumerable<Vote> GetByStory(Guid storyId)
        {
            return _voteRepo.GetByStory(storyId);
        }

        // GET api/vote/by-criteria
        [HttpGet("by-criteria")]
        public Vote GetByCriteria([FromQuery] VoteCriteriaModel model)
        {
            return _voteRepo.GetByCriteria(model.StoryId, model.VoterId);
        }

        // POST api/vote
        [HttpPost]
        public Vote Post([FromBody] Vote vote)
        {
            return _voteRepo.Create(vote);
        }

        // PUT api/vote/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Vote vote)
        {
            _voteRepo.Update(id, vote);
        }
    }
}