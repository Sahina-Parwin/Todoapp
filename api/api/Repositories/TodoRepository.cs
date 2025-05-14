using api.Data;
using api.Models;

namespace api.Repositories
{
    public class TodoRepository : ITodoRepository
    {
       private readonly TodoContext context;
        public TodoRepository(TodoContext context)
        {
            this.context = context;
        }
        public List<Todoitem> GetAll()
        {
            return context.Todoitems.ToList();
        }
    }
}
