using api.Models;

namespace api.Repositories
{
    public interface ITodoRepository 
    {
        public List<Todoitem> GetAll();
    }
}
