using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.Services;
using TestApplication.Services.Models;

namespace TestApplication.Controllers {

    [Route("api/todo")]
    [ApiController]
    public class TestController : ControllerBase{
        private ITodoService _service;
        private IMapper _mapper;

        public TestController(ITodoService service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id?}", Name ="gettasks")]
        public IActionResult GetTasks(int ?id) {
            var todos = _service.CreateGetTasks();

            if (id == null) return Ok(todos);

            return Ok(todos.Where(t => t.Id == id).ToList());
        }
        [HttpPost]
        public IActionResult AddNewTodo(Todo tdo) {
            var newtodo = _service.AddNewTodo(tdo);

            return CreatedAtRoute("gettasks",new { id = newtodo.Id}, newtodo);
        }
        [HttpPut("update/{id}")]
        public ActionResult UpdateTodo(int id, Todo todo) {
            var ExTodo = _service.GetTodo(id);
            ExTodo.title = todo.title;
            ExTodo.description = todo.description;
            ExTodo.created = todo.created;
            ExTodo.due = todo.due;
            ExTodo.status = todo.status;

            _service.UpdateTodo(todo);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public ActionResult DeleteTodo(int id) {
            var todo = _service.GetTodo(id);

            if (todo == null) return NotFound();

            _service.DeleteTodo(todo);

            return NoContent();
        }
        
    }
}
