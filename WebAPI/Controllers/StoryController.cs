using System;
using System.Collections.Generic;
using DAL.Repo;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class StoryController : Controller
    {
        private readonly StoryRepo _storyRepo;

        public StoryController(StoryRepo storyRepo)
        {
            _storyRepo = storyRepo;
        }
        
        // GET api/story
        [HttpGet]
        public IEnumerable<Story> Get()
        {
            return _storyRepo.GetAll();
        }
        
        // GET api/story/5
        [HttpGet("{id}")]
        public Story Get(Guid id)
        {
            return _storyRepo.GetById(id);
        }

        // GET api/story/by-session/2
        [HttpGet("by-session/{sessionId}")]
        public IEnumerable<Story> GetBySession(Guid sessionId)
        {
            return _storyRepo.GetBySession(sessionId);
        }

        // POST api/story
        [HttpPost]
        public Story Post([FromBody] Story story)
        {
            return _storyRepo.Create(story);
        }

        // PUT api/story/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Story story)
        {
            _storyRepo.Update(id, story);            
        }
    }
}