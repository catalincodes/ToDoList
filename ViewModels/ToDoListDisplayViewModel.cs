using System.Collections.ObjectModel;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
	public class ToDoListDisplayViewModel
	{
		public ObservableCollection<ToDoItem> ToDoItems { get; set; }

		public ToDoListDisplayViewModel()
		{
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
	}
}
