using System;
using Xamarin.Forms;

namespace LetsWork
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}

		//async void OnLoginButtonClicked(object sender, EventArgs e)
		//{
		//	//var user = new User
		//	//{
		//	//	Username = usernameEntry.Text,
		//	//	Password = passwordEntry.Text
		//	//};

		//	//var isValid = AreCredentialsCorrect(user);
		//	//if (isValid)
		//	//{
		//	//	App.IsUserLoggedIn = true;
		//	//	Navigation.InsertPageBefore(new MainPage(), this);
		//	//	await Navigation.PopAsync();
		//	//}
		//	//else
		//	//{
		//	//	messageLabel.Text = "Login failed";
		//	//	passwordEntry.Text = string.Empty;
		//	//}
		//}

		//bool AreCredentialsCorrect(User user)
		//{
		//	//return user.Username == Constants.Username && user.Password == Constants.Password;
		//}


		//async void OnLoginButtonClicked(object sender, EventArgs e)
		//{
		//	var user = new User
		//	{
		//		Username = usernameEntry.Text,
		//		Password = passwordEntry.Text
		//	};

		//	var isValid = AreCredentialsCorrect(user);
		//	if (isValid)
		//	{
		//		App.IsUserLoggedIn = true;
		//		Navigation.InsertPageBefore(new MainPage(), this);
		//		await Navigation.PopAsync();
		//	}
		//	else
		//	{
		//		messageLabel.Text = "Login failed";
		//		passwordEntry.Text = string.Empty;
		//	}
		//}


		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
            var user = new LoginUser
			{
				Name = usernameEntry.Text,
				Password = passwordEntry.Text
			};

            //var isValid = AreCredentialsCorrect(user);
            var isValid = true;
            if (isValid)
			{
				App.IsUserLoggedIn = true;
				Navigation.InsertPageBefore(new TaskListPage(), this);
				await Navigation.PopAsync();
			}
			else
			{
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}


		//bool AreCredentialsCorrect(LoginUser user)
		//{
		//	////return user.Username == Constants.Username && user.Password == Constants.Password;
		//	//HttpClient client = await GetClient();


		//}




	
	}
}
