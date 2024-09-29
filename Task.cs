using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Task
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueTime { get; set; }

        public Task(string title, DateTime dueTime) 
        {
            Title = title;
            IsCompleted = false;
            DueTime = dueTime;
        }

        public override string ToString()
        {
            return $"{Title} выполнить до: {DueTime}";
        }
    }
}
