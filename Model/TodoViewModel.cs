using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CRUD_TODO_EXOS.Utils;
using CRUD_TODO_EXOS.DAL_Models;

namespace CRUD_TODO_EXOS.Model
{
    public class TodoViewModel : PropertyChangedUtils
    {
        public Model_TodoList ModelToDoList = new Model_TodoList();
        private ICommand _deleteCommand;

        private Todo _todo;
        public TodoViewModel(Todo todo)
        {
            _todo = todo ?? throw new ArgumentNullException(nameof(todo));
            Id = todo.id;
            Titre = todo.Titre;
            Description = todo.Description;
            Date = todo.Date;
            Done = todo.Done;
        }
      

       

        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged(nameof(Id));
                }
            }
        }


        private string _titre;
        public string  Titre
        {
            get { return _titre; }
            set
            {
                if (_titre != value)
                {
                    _titre = value;
                    RaisePropertyChanged(nameof(Titre));
                }
            }
        }


        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged(nameof(Description));
                }
            }
        }


        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    RaisePropertyChanged(nameof(Date));
                }
            }
        }


        private bool _done;
        

        public bool Done
        {
            get { return _done; }
            set
            {
                if (_done != value)
                {
                    _done = value;
                    RaisePropertyChanged(nameof(Done));
                }
            }
        }



        //liste des commande 

        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ??= new RelayCommand(DeleteTodo, CanDeleteTodo);
            }
        }

        private void DeleteTodo()
        {
            ModelToDoList.DeleteOne(_todo.id);
        }

        public bool CanDeleteTodo()
        {
            return true;
        }
    }
}
