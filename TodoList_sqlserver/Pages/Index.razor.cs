using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_sqlserver.Data;

namespace TodoList_sqlserver.Pages
{
    public class IndexFunc : ComponentBase
    {
        //attribute

        [Inject] protected DataContext _context { set; get; }

        public TodoItem item;

        //Contructor

        //OnInitialized

        protected override void OnInitialized()
        {
            item = new TodoItem();
        }

        //method
        protected void AddTodoItem()
        {
            if (item.Title != null)
            {
                _context.TodoItem.Add(item);
                _context.SaveChanges();
                item = new TodoItem();
            }

        }
        protected void enterCreate(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                AddTodoItem();
            }
        }

    }
}
