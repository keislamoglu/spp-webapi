using System;

namespace Entity
{
    public class Voter
    {
        public Guid Id { get; set; }
        public string Nick { get; set; }
        public Guid SessionId { get; set; }
        public string Type { get; set; }
    }
}