using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LetsWork
{
    public partial class TaskPage : ContentPage
    {
        public TaskPage()
        {
            InitializeComponent();
        }


		void OnCancelActivated(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

    }
}
