using api.Models;

namespace api.Services
{
    public interface ITodoService
    {
        
     public List<Todoitem> GetAll();

        public Todoitem GetById(int id);

        public Todoitem Create(Todoitem item);

        public Todoitem Update(Todoitem item);
        public Todoitem Delete(int id);

    }
}
