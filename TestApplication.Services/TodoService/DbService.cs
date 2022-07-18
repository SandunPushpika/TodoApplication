using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.DataAccess;

namespace TestApplication.Services
{

    public class DbService : ITodoService {
        private readonly TodoContext _context = new TodoContext();
        public List<Todo> CreateGetTasks() {
            return _context.Todos.ToList();
        }

        public Todo AddNewTodo(int authorid, Todo todo) {
            todo.authorid = authorid;
            _context.Todos.Add(todo);
            _context.SaveChanges();

            return todo;
        }
        public void UpdateTodo(Todo todo) {
            _context.SaveChanges();
        }

        public Todo AddNewTodo(Todo todo) {
            _context.Todos.Add(todo);
            _context.SaveChanges();

            return todo;
        }

        public Todo GetTodo(int id) {
            return _context.Todos.Find(id);
        }

        public void DeleteTodo(Todo todo) {
            _context.Todos.Remove(todo);
            _context.SaveChanges();
        }
    }
}
