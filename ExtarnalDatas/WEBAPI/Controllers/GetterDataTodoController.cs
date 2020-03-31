using ModelLocal.Models;
using ModelLocal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI.Controllers
{
    /// <summary>
    /// Permet de controller les todo
    /// </summary>
    public class GetterDataTodoController : ApiController
    {
        TodoServices DalTodo = new TodoServices();

        [Route("api/GetListTodo/")]
        public List<Todo> GetListTodo()
        {
            return DalTodo.GetAll();
        }

        [Route("api/GetTodo/{id:int}")]
        public Todo GetTodo(int id)
        {
            Todo OneTodo = DalTodo.Get(id);
            return OneTodo;
        }

        [HttpPost]
        [Route("api/PostTodo")]
        public void PostTodo(Todo todo)
        {
            DalTodo.Create(todo);
        }


        [HttpPut]
        [Route("api/PutTodo")]
        public void PutTodo(Todo todo)
        {
            DalTodo.Update(todo);
        }

        /// <summary>
        /// Test
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("api/DeleteTodo/{id:int}")]
        public void DeleteTodo(int id)
        {
            DalTodo.Delete(id);
        }

    }
}
