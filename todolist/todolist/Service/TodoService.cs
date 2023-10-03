using Microsoft.EntityFrameworkCore;
using todolist.Data;
using todolist.NewFolder;

namespace todolist.Service
{
    public class TodoService : ITodoService
    {
        private readonly AppDBContext _context;



        public TodoService(AppDBContext context)
        {

            _context = context;
        }


        public List<todoTask> GetAllTodo()
        {
            try
            {
                var shops = _context.Todos.ToList();
                return shops;

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void DeleteTodo(int id)
        {
            var itemToDelete = _context.Todos.FirstOrDefault(x => x.Number == id);
               _context.Todos.Remove(itemToDelete);
            _context.SaveChanges();
        }

        public void UpdateTodo(int id, todoTask todo)
        {

            if (id != todo.Number)
            {
                throw new Exception("id not found");
            }


            _context.Entry(todo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CreateTodo(TodoPost todo)
        {

            try
            {
                var newStudent = new todoTask()
                {
                    Name = todo.Name,
                    Description= todo.Description,
                    Number = todo.Number,
                    status = todo.status,
                    
                };

                _context.Todos.Add(newStudent);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
