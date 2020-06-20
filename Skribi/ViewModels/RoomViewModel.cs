using System.Collections.Generic;
using Skribi.Models;

namespace Skribi.ViewModels
{
    public class RoomViewModel
    {
        public Room Room { get; set; }
        public List<Thread> Threads { get; set; }
    }
}
