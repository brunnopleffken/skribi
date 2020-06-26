using System;
using System.Collections.Generic;
using Skribi.Models;

namespace Skribi.ViewModels
{
    public class ThreadViewModel
    {
        public Thread Thread { get; set; }
        public List<Reply> Replies { get; set; }
    }
}
