using System;

namespace Entity
{
    public class Story
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid SessionId { get; set; }
        public string Point { get; set; }
    }
}