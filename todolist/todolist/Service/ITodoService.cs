using todolist.NewFolder;

namespace todolist.Service
{
    public interface ITodoService
    {
        public void CreateTodo(TodoPost item);
        public List<todoTask> GetAllTodo();
        public void DeleteTodo(int id);
        public void UpdateTodo(int id, todoTask shop);
    }
}
