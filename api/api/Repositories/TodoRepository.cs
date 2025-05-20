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

        public Todoitem Create(Todoitem item)
        {
            // create row
            context.Add(item);
            // or context.Todoitems.Add(item);


            // Save changes
            context.SaveChanges();
            // Return new row

            return item;
        }

        public Todoitem Delete(int id)
        {
          // fetch item 
          Todoitem item = context.Todoitems.Where(src  => src.Id == id).FirstOrDefault();
            if (item == null)
            {
                throw new Exception("item not found");
            }
          // delete item
          context.Todoitems.Remove(item);
            // save changes 
            context.SaveChanges();
            // return
            return item;
        }

        public List<Todoitem> GetAll()
        {
            return context.Todoitems.ToList();
        }

        public Todoitem GetById(int id)
        {
            // fetch item 
            Todoitem item = context.Todoitems.Where(src => src.Id == id).FirstOrDefault();
            if (item == null)
            {
                throw new Exception("item not found");
            }
           
            // return
            return item;
        }

        public Todoitem Update(Todoitem item)
        {
           // update row
           context.Update(item);

            // save changes
            context.SaveChanges();

            // Return
            return item;
        }
    }
}
