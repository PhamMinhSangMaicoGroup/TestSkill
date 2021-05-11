using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_sqlserver.Data;

namespace TodoList_sqlserver.Components
{
    public class ListTodoModel : ComponentBase
    {
        [Parameter]
        public DataContext _context { set; get; }
        [Parameter]
        public bool isDone { set; get; }

        public int total ;
        //
        protected override void OnInitialized()
        {
        }
        //method
        public void Done(int id)
        {
            _context.TodoItem.Find(id).Done = true;
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            TodoItem todo = _context.TodoItem.Find(id);
            if (todo != null)
            {
                _context.Remove(todo);
                _context.SaveChanges();
            }

        }
        public void EnterCase(TodoItem todo, KeyboardEventArgs eventArgs)
        {          
            if (eventArgs.Key == "Enter")
            {
                _context.TodoItem.Find(todo.Id).Title = todo.Title;
                _context.SaveChanges();

            }
        }
        
    }
}
