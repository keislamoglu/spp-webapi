using System;

namespace Entity
{
    public class Session
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfVoters { get; set; }
        public Guid? ActiveStoryId { get; set; }
    }
}