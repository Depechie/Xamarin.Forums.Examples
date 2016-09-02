using System;
using System.Collections.Generic;
using System.Linq;
using ListView.ExpandingFooter.ViewModels;
using Xamarin.Forms;

namespace ListView.ExpandingFooter.Pages
{
	public partial class Scenario02MasterPage : ContentPage
	{
		Scenario02ViewModel _viewModel;

		public Scenario02MasterPage()
		{
			_viewModel = new Scenario02ViewModel();

			InitializeComponent();

			BindingContext = _viewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			UpdateFooterHeight();
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();
			UpdateFooterHeight();
		}

		private void UpdateFooterHeight()
		{
			const int minHeight = 80;
			// why the extra 2? Good question, I'm not sure what's accounting for that extra spacing.
			var requestedHeight = Math.Floor(App.Device.Height - (MenuListView.RowHeight * _viewModel.ItemsSource.Count()) - App.Device.StatusBarHeight - 2);
			ListViewFooter.HeightRequest = requestedHeight >= minHeight ? requestedHeight : minHeight;
		}
	}
}