using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
	public class ToDoItem
	{
		public required Guid Id { get; set; }
		public string Title { get; set; } = "";
		public string Description { get; set; } = "";
		public bool IsDone { get; set; }
		public DateTime DueDate { get; set; }

		public override bool Equals(object? obj)
		{
			return obj is ToDoItem item &&
				   Title == item.Title &&
				   Description == item.Description &&
				   IsDone == item.IsDone &&
				   DueDate == item.DueDate;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
