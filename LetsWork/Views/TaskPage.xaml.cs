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
			labelUsername.Text = App.Username;

		}


		void OnCancelActivated(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

        protected void nameEntry_Focused(object sender, FocusEventArgs e)
        {
			nameEntry.Focus();
			nameEntry.Unfocus();
        }

		protected void descriptionEntry_Focused(object sender, FocusEventArgs e)
		{
			descriptionEntry.Focus();
			descriptionEntry.Unfocus();
		}

		protected void coordinatorName_Focused(object sender, FocusEventArgs e)
		{
			coordinatorName.Focus();
			coordinatorName.Unfocus();
		}

		protected void coordinatorPhone_Focused(object sender, FocusEventArgs e)
		{
			coordinatorPhone.Focus();
			coordinatorPhone.Unfocus();
		}

		protected void startDate_Focused(object sender, FocusEventArgs e)
		{
			startDate.Focus();
			startDate.Unfocus();
		}

		protected void volunteersRequired_Focused(object sender, FocusEventArgs e)
		{
			volunteersRequired.Focus();
			volunteersRequired.Unfocus();
		}



	}
}
