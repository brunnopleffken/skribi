using System;

namespace Skribi.Models
{
    public class Reply
    {
        public int Id { get; set; }

        public int ThreadId { get; set; }
        public Thread Thread { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EditedAt { get; set; }
    }
}
