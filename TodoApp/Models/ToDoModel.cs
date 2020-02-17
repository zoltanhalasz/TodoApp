using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class ToDoModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
