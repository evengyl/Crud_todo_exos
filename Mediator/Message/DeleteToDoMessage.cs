using CRUD_TODO_EXOS.Model;
using System;

namespace CRUD_TODO_EXOS.ViewModel
{
    public class DeleteToDoMessage
    {
        public TodoViewModel ViewModel { get; private set; }
        public DeleteToDoMessage(TodoViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }
    }
}