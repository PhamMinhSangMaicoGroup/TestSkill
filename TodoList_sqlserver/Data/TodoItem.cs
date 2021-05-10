using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList_sqlserver.Data
{
    public class TodoItem
    {
        [Key]
        public int Id { set; get; }
        public string Title { set; get; }
        public bool Done { set; get; } = false;
    }
}
