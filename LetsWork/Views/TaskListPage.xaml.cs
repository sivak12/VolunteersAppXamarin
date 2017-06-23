using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LetsWork
{
    public partial class TaskListPage : ContentPage
    {
		readonly TaskManager taskManager = new TaskManager();


		public TaskListPage()
        {
            InitializeComponent();
        }


		protected async override void OnAppearing()
		{
			base.OnAppearing();

			//if (Constants.RestUrl.Contains("developer.xamarin.com"))
			//{
			//	if (!alertShown)
			//	{
			//		await DisplayAlert(
			//			"Hosted Back-End",
			//			"This app is running against Xamarin's read-only REST service. To create, edit, and delete data you must update the service endpoint to point to your own hosted REST service.",
			//			"OK");
			//		alertShown = true;
			//	}
			//}

			//listView.ItemsSource = await App.TaskManager.GetTasksAsync();
			listView.ItemsSource = await taskManager.GetAll();



		}
    }
}
