using System;
using System.Linq;
using Xamarin.Forms;


namespace LetsWork
{
	public partial class SignUpPage : ContentPage
	{

		readonly LoginUserManager loginUserManager = new LoginUserManager();

		public SignUpPage()
		{
			InitializeComponent();
		}
	
		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			var loginUser = new LoginUser()
			{
				Name = usernameEntry.Text,
				Password = passwordEntry.Text,
				Email = emailEntry.Text
			};

			// Sign up logic goes here

			
            //await loginUserManager.Add(loginUser);


			//Book book = await manager.Add(title, author, genre);
			//books.Add(book);



			var signUpSucceeded = AreDetailsValid(loginUser);
			if (signUpSucceeded)
			{
				await loginUserManager.Add(loginUser);

				var rootPage = Navigation.NavigationStack.FirstOrDefault();
				if (rootPage != null)
				{
					App.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new TaskListPage(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync();
				}
			}
			else
			{
				messageLabel.Text = "Sign up failed";
			}
		}


		bool AreDetailsValid(LoginUser loginUser)
		{
			return (!string.IsNullOrWhiteSpace(loginUser.Name) && !string.IsNullOrWhiteSpace(loginUser.Password) && !string.IsNullOrWhiteSpace(loginUser.Email) && loginUser.Email.Contains("@"));
		}
	}
}
