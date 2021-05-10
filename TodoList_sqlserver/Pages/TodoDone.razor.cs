using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_sqlserver.Data;

namespace TodoList_sqlserver.Pages
{
    public class TodoDoneModel : ComponentBase
    {
        //attribute

        [Inject] protected DataContext _context { set; get; }


        //Contructor

        //OnInitialized

        protected override void OnInitialized()
        {

        }

        //method
    }
}
