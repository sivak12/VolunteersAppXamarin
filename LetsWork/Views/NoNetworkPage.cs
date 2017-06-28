using System;

using Xamarin.Forms;

namespace LetsWork
{
    public class NoNetworkPage : ContentPage
    {
        public NoNetworkPage()
        {
			BackgroundColor = Color.FromRgb(0xf0, 0xf0, 0xf0);
			Content = new Label()
			{
				Text = "Please connect to internet",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				TextColor = Color.FromRgb(0x40, 0x40, 0x40),
			};
        }

		

    }
}

