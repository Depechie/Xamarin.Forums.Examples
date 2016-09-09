using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListView.ExpandingFooter.ViewModels
{
	public class Scenario02ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}

		private IEnumerable<Models.MenuItem> _itemsSource;
		public IEnumerable<Models.MenuItem> ItemsSource
		{
			get { return _itemsSource; }
			set
			{
				_itemsSource = value;
				NotifyPropertyChanged();
			}
		}

		public Scenario02ViewModel()
		{
			List<Models.MenuItem> menuItems = new List<Models.MenuItem>()
			{
				new Models.MenuItem() { Title = "menu item 1" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 3" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 2" },
				new Models.MenuItem() { Title = "menu item 8" },
				new Models.MenuItem() { Title = "menu item 9" },
				new Models.MenuItem() { Title = "menu item 10" },
				new Models.MenuItem() { Title = "menu item 11" },
				new Models.MenuItem() { Title = "menu item 12" }
			};

			ItemsSource = menuItems;
		}
	}
}

