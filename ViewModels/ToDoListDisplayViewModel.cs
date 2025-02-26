using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ToDoList.Commands;
using ToDoList.Models;
using ToDoList.Windows;

namespace ToDoList.ViewModels
{
	public class ToDoListDisplayViewModel : INotifyPropertyChanged
	{
		public ObservableCollection<ToDoItem> ToDoItems { get; set; }

		public ICommand OpenAddTaskViewCommand { get; }

		public ToDoListDisplayViewModel()
		{
			OpenAddTaskViewCommand = new DelegateCommand(
				_ =>
				{
					OpenAddTaskView();
				},
				_ =>
				{
					return true;
				}
			);

			ToDoItems = new ObservableCollection<ToDoItem>
				{
					new ToDoItem
					{
						Id = Guid.NewGuid(),
						Title = "Buy Milk",
						Description = "Buy Milk",
						DueDate = DateTime.Now.AddDays(1)
					},
					new ToDoItem
					{
						Id = Guid.NewGuid(),
						Title = "Buy Bread",
						Description = "Buy Bread",
						DueDate = DateTime.Now.AddDays(2)
					},
					new ToDoItem
					{
						Id = Guid.NewGuid(),
						Title = "Buy Eggs",
						Description = "Buy Eggs",
						DueDate = DateTime.Now.AddDays(3)
					}
				};
		}

		private void OpenAddTaskView()
		{
			var addTaskWindow = new AddTaskWindow();
			addTaskWindow.ShowDialog();
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
