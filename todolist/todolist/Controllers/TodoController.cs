using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todolist.NewFolder;
using todolist.Service;

namespace todolist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;

        }

        [HttpPost]
        public ActionResult<todoTask> CreateTodo([FromBody] TodoPost todo)
        {


            _todoService.CreateTodo(todo);
            return NoContent();
        }

        [HttpGet]
        public ActionResult<List<todoTask>> GetAllTodo()
        {
            var response = _todoService.GetAllTodo();
            return Ok(response);
        }

        [HttpDelete("id")]
        public ActionResult DeleteTodo([FromQuery] int id)
        {

            _todoService.DeleteTodo(id);    
            return NoContent();
        }

        [HttpPut("id")]
        public ActionResult UpdateTodo(int id, [FromBody] todoTask shop)
        {
            _todoService.UpdateTodo(id, shop);
            return NoContent();
        }
    }
}
