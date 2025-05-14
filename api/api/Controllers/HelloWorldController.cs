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

        [HttpPost("create")]
        public void create()
        {

        }
        [HttpPut("update/{id}")]
        public void update(int id)
        {

        }
        [HttpPost("delete/{id}")]
        public void delete(int id)
        {

        }
        [HttpPut("complete/{id}")]
        public void complete(int id)
        {

        }

    }
}
