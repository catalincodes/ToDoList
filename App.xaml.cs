using System.Windows;
using ToDoList.Models;

namespace ToDoList
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			ToDoCollection toDoList = new ToDoCollection();

			ToDoItem item1 = new ToDoItem
			{
				Id = Guid.NewGuid(),
				Title = "Buy milk",
				Description = "Buy milk from the store",
				IsDone = false,
				DueDate = DateTime.Now.AddDays(1)
			};

			ToDoItem item2 = new ToDoItem
			{
				Id = Guid.NewGuid(),
				Title = "Buy bread",
				Description = "Buy bread from the store",
				IsDone = false,
				DueDate = DateTime.Now.AddDays(2)
			};

			toDoList.AddItem(item1);
			toDoList.AddItem(item2);

			var list = toDoList.GetItems();

			base.OnStartup(e);
		}

	}

}
