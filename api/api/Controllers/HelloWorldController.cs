using api.Models;
using api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("Todo")]
    
    public class HelloWorldController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HelloWorldController> _logger;

        private readonly ITodoService _todoService;

        public HelloWorldController(ILogger<HelloWorldController> logger, ITodoService todoService)
        {
            _logger = logger;
            _todoService = todoService;
        }

        [HttpGet("getall")]
        public IEnumerable<Todoitem> Get()
        {
            return _todoService.GetAll();
        }

        [HttpGet("get/{id}")]
        public ActionResult<Todoitem> GetById(int id)
        {
            return Ok(_todoService.GetById(id));

        }

        [HttpPost("create")]
        public ActionResult<Todoitem> create([FromBody] Todoitem item)
        {
            try
            {
                return Ok(_todoService.Create(item));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }

        }
        [HttpPut("update/{id}")]
        public ActionResult<Todoitem> update([FromBody] Todoitem item, int id)
        {
            try
            {
                return Ok(_todoService.Update(item));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost("delete/{id}")]
        public ActionResult<Todoitem> delete(int id)
        {
            try
            {
                return Ok(_todoService.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut("complete/{id}")]
        public ActionResult<Todoitem> complete([FromBody] Todoitem item, int id)
        {

            try
            {
                return Ok(_todoService.Complete(item));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
