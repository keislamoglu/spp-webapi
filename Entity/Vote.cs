using System;

namespace Entity
{
    public class Vote
    {
        public Guid Id { get; set; }
        public string Point { get; set; }
        public Guid VoterId { get; set; }
        public Guid StoryId { get; set; }
    }
}