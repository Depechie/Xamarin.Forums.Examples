using System;
using System.Linq;
using ListView.ExpandingFooter.ViewModels;
using Xamarin.Forms;

namespace ListView.ExpandingFooter.Pages
{
	public partial class Scenario03MasterPage : ContentPage
	{
		Scenario02ViewModel _viewModel;

		public Scenario03MasterPage()
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
			var requestedHeight = MenuListView.RowHeight * _viewModel.ItemsSource.Count();
			MenuListView.HeightRequest = requestedHeight;
		}
	}
}

