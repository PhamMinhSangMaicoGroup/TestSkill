using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Data;

namespace TodoList.Pages
{
    public class DoneFunc : ComponentBase
    {
        [Inject] protected TodoItemService service { set; get; }

        protected List<TodoModel> data;

        protected override void OnInitialized()
        {
            data = service.GetData();

        }
    }
}
