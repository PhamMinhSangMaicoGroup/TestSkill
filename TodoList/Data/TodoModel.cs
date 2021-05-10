using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data
{
    public class TodoModel
    {
        public string Title { set; get; }
        public string Note { set; get; }
        public DateTime Date { set; get; }
        public DateTime Time { get; set; }
        public bool Done { set; get; }
    }
}
