namespace ToDoList.Models
{
	public class ToDoCollection
	{
		private readonly List<ToDoItem> _items = new();

		public IEnumerable<ToDoItem> GetItems()
		{
			return _items;
		}

		public void AddItem(ToDoItem item)
		{
			_items.Add(item);
		}

		public void RemoveItem(ToDoItem item)
		{
			_items.Remove(item);
		}
	}
}
