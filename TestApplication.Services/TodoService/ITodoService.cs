using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Services
{
    public interface ITodoService
    {
        public List<Todo> CreateGetTasks();
        public Todo GetTodo(int id);
        public void UpdateTodo(Todo todo);
        public Todo AddNewTodo( Todo todo);
        public void DeleteTodo(Todo todo);

    }
}
