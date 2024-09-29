using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Task
    {
        private string Title { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title) 
        {
            Title = title;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
