using api.Models;
using api.Repositories;

namespace api.Services
{
    public class TodoService :ITodoService
    {
        private readonly ITodoRepository todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }
        public List<Todoitem> GetAll()
        {
            return todoRepository.GetAll();
        }
    }
}
