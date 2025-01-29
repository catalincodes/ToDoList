using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
	public class ToDoItem
	{
		public required Guid Id { get; init; } = Guid.NewGuid();
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public bool IsDone { get; set; }
		public DateTime DueDate { get; set; }

		public override bool Equals(object? obj)
		{
			if (obj is ToDoItem item)
			{
				return Id == item.Id;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
	}
}
