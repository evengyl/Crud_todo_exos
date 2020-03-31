using DAL2.IRepositories;
using DAL2.Services;
using Dal = DAL2.Models;

using ModelLocal.Models;
using ModelLocal.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLocal.Services
{
    public class TodoServices : IRepository<Todo>
    {


        TodoRepository TodoDal;


        public TodoServices()
        {
            TodoDal = new TodoRepository();
        }

        public void Create(Todo todo)
        {
            TodoDal.Create(todo.ToGlobal());
        }

        public void Delete(int id)
        {
            TodoDal.Delete(id);
        }

        public Todo Get(int id)
        {
            return TodoDal.Get(id).ToLocal();
        }

        public List<Todo> GetAll()
        {
            return TodoDal.GetAll().Select(x => x.ToLocal()).ToList();
        }

        public void Update(Todo film)
        {
            TodoDal.Update(film.ToGlobal());
        }

        public Todo GetBy(string row, string value)
        {
            return TodoDal.GetBy(row, value).ToLocal();
        }

    }
}
