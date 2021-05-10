using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TodoList.Data
{
    public class TodoItemService
    {
        private readonly string _file = "Data\\TodoList.json";

        private List<TodoModel> _data = new List<TodoModel>()
        {
            new TodoModel()
                {
                    Title=" Default"
                }
        };
        public List<TodoModel> GetData()
        {
            if (File.Exists(_file))
            {
                using var file = File.OpenText(_file);
                var serializer = new JsonSerializer();
                _data = serializer.Deserialize(file, typeof(List<TodoModel>)) as List<TodoModel>;
            }
            return _data;
        }

        public void SaveChanges(List<TodoModel> data)
        {
            using var file = File.CreateText(_file);
            var serializer = new JsonSerializer();
            serializer.Serialize(file, data);
        }
    }
}
