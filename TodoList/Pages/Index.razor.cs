using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Data;

namespace TodoList.Pages
{
    public class IndexFunc : ComponentBase
    {
        [Inject] protected TodoItemService service { set; get; }

        //attribute
        protected List<TodoModel> data;
        protected TodoModel item;

        //OnInitialized

        protected override void OnInitialized()
        {
            data = service.GetData();
            item = new TodoModel();
            item.Done = false;
            item.Date = DateTime.Now;
            item.Time = DateTime.Now;
        }
        
        protected void AddTodoItem()
        {
            if (!string.IsNullOrWhiteSpace(item.Title))
            {
                data.Add(item);
                Save();
            }
        }
        protected void enterCreate(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                AddTodoItem();
            }
        }

        protected void Save() 
        {
            List<TodoModel> fullData = service.GetData();
            service.SaveChanges(data); 
        }
    }
}
