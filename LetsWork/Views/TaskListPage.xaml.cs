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

			//listView.ItemsSource = await App.TaskManager.GetTasksAsync();
			listView.ItemsSource = await taskManager.GetAll();
            labelUsername.Text = App.Username;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var task = e.SelectedItem as Task;
			var taskPage = new TaskPage();
			taskPage.BindingContext = task;
			Navigation.PushAsync(taskPage);
		}



		async void OnRefresh(object sender, EventArgs e)
		{

			listView.ItemsSource = await taskManager.GetAll();

			//var bookCollection = await manager.GetAll();

			//foreach (Book book in bookCollection)
			//{
			//	if (books.All(b => b.ISBN != book.ISBN))
			//		books.Add(book);
			//}
		}

    }
}
