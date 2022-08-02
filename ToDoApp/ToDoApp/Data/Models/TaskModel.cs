using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Data.Models
{
    public class TaskModel
    {
        public string name { get; set; }
        public bool isCompleted { get; set; }

        public bool mouseOver;
    }
}
