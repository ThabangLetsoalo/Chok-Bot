using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Task
    {

        public class TaskItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime? ReminderDate { get; set; }
            public bool IsCompleted { get; set; }
        }

    }
}
