using System;
using Xamarin.Forms;

namespace LetsWork
{
	public partial class LoginPage : ContentPage
	{
		readonly LoginUserManager loginUserManager = new LoginUserManager();

		public LoginPage()
		{
			InitializeComponent();
		}

		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}

		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
            var user = new LoginUser
			{
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};

            var isValid = AreCredentialsCorrectAsync(user);
            if (await isValid)
			{
				App.IsUserLoggedIn = true;
                App.Username = usernameEntry.Text;

				Navigation.InsertPageBefore(new TaskListPage(), this);
				await Navigation.PopAsync();
			}
			else
			{
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}

        async System.Threading.Tasks.Task<bool> AreCredentialsCorrectAsync(LoginUser user)
        {
            
            LoginUser existingUser = await loginUserManager.CheckUser(user);

            if ((existingUser != null) && existingUser.Password.Equals(user.Password))
                return true;

            return false;

        }





    }
}
