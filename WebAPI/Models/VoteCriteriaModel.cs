using System;

namespace WebAPI.Models
{
    public class VoteCriteriaModel
    {
        public Guid StoryId { get; set; }
        public Guid VoterId { get; set; }
    }
}