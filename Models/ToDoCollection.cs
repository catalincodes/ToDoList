namespace ToDoList.Models
{
	public class ToDoCollection
	{
		public readonly List<ToDoItem> Items;

		public ToDoCollection()
		{
			Items = new List<ToDoItem>();
		}

		public IEnumerable<ToDoItem> GetItems()
		{
			return Items;
		}

		public void AddItem(ToDoItem item)
		{
			Items.Add(item);
		}

		public void RemoveItem(ToDoItem item)
		{
			Items.Remove(item);
		}
	}
}
