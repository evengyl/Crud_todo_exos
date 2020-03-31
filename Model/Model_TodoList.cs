using CRUD_TODO_EXOS.DAL_Models;
using CRUD_TODO_EXOS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_TODO_EXOS.Model
{
    public class Model_TodoList : ControllerAPI
    {
        public Model_TodoList() : base("http://localhost:64408/api/")
        {

        }
        public IEnumerable<Todo> GetALL()
        {
            return this.GetAllAPI<IEnumerable<Todo>>("GetListTodo");
        }

        public Todo GetOne(int id)
        {
            return this.GetOneAPI<Todo>("GetTodo", id);
        }

        public void InsertOne(Todo todo)
        {
            PostAPI<Todo>("PostTodo", todo);
        }

        public void Update(Todo todo)
        {
            PutAPI<Todo>("PutTodo", todo);
        }

        public void DeleteOne(int id)
        {
            Delete("DeleteTodo", id);
        }
    }
}
