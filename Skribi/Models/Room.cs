using System;
using System.Collections.Generic;

namespace Skribi.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }

        public List<Thread> Threads { get; set; }
    }
}
