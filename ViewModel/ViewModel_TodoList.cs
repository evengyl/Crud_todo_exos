using CRUD_TODO_EXOS.Mediator;
using CRUD_TODO_EXOS.Model;
using CRUD_TODO_EXOS.Utils;
using CRUD_TODO_EXOS.DAL_Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CRUD_TODO_EXOS.ViewModel
{
    public class ViewModel_TodoList : PropertyChangedUtils
    {
        public Model_TodoList ModelToDoList = new Model_TodoList();

        private ObservableCollection<TodoViewModel> _listTodo;

        public ObservableCollection<TodoViewModel> ListTodo
        {
            get { return _listTodo; }
            set { _listTodo = value; }
        }

        private void OnDeleteToDo(DeleteToDoMessage obj)
        {
            ListTodo.Remove(obj.ViewModel);
        }


        public ViewModel_TodoList()
        {
            Messenger<DeleteToDoMessage>.Instance.Register(OnDeleteToDo);
            _listTodo = new ObservableCollection<TodoViewModel>(ModelToDoList.GetALL().Select(td => new TodoViewModel(td)));
        }



    }
}
