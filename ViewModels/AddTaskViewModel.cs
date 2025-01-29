using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ToDoList.Commands;

namespace ToDoList.ViewModels
{
	public class AddTaskViewModel : INotifyPropertyChanged
	{
		private string _title = string.Empty;
		private string _description = string.Empty;
		private DateTime _dueDate = DateTime.Now;
		private string _dueTime = string.Empty;

		public string Title
		{
			get => _title;
			set
			{
				_title = value;
				OnPropertyChanged();
			}
		}

		public string Description
		{
			get => _description;
			set
			{
				_description = value;
				OnPropertyChanged();
			}
		}

		public DateTime DueDate
		{
			get => _dueDate;
			set
			{
				_dueDate = value;
				OnPropertyChanged();
			}
		}

		public string DueTime
		{
			get => _dueTime;
			set
			{
				_dueTime = value;
				OnPropertyChanged();
			}
		}

		public ICommand AddTaskCommand { get; }

		public AddTaskViewModel()
		{
			DueDate = DateTime.Now;
			AddTaskCommand = new DelegateCommand(_ => AddTask());
		}

		private void AddTask()
		{
			// Add task logic here
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
