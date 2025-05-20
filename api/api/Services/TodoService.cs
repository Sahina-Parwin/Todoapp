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

        public Todoitem Create(Todoitem item)
        {
          return todoRepository.Create(item);

            //OR

         //Todoitem newrow = todoRepository.Create(item);
         //   return newrow;


            // return item;
        }

        public Todoitem Delete(int id)
        {
           return todoRepository.Delete(id);
        }

        public List<Todoitem> GetAll()
        {
            return todoRepository.GetAll();
        }

        public Todoitem GetById(int id)
        {
            return todoRepository.GetById(id);
        }

        public Todoitem Update(Todoitem item)
        {
            return todoRepository.Update(item);

            
        }
    }
}
