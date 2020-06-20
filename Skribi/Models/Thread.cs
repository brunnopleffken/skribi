using System;

namespace Skribi.Models
{
    public class Thread
    {
        public int Id { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsLocked { get; set; }

    }
}
