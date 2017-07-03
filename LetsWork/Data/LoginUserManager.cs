	using System;
	using System.Collections.Generic;
	using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
	using Newtonsoft.Json;

	namespace LetsWork
	{
	    public class LoginUserManager
	    {
	   
	                const string Url = "http://letswork.azurewebsites.net/api/loginuser/";


				private async Task<HttpClient> GetClient()
				{
					HttpClient client = new HttpClient();


					//if (string.IsNullOrEmpty(authorizationKey))
					//{
					//  authorizationKey = await client.GetStringAsync(Url + "login");
					//  authorizationKey = JsonConvert.DeserializeObject<string>(authorizationKey);
					//}

					//client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
					client.DefaultRequestHeaders.Add("Accept", "application/json");
					return client;
				}


				//public async Task<Book> Add(string title, string author, string genre)
				//{
				//	// TODO: use POST to add a book
				//	Book book = new Book()
				//	{
				//		Title = title,
				//		Authors = new List<string>(new[] { author }),
				//		ISBN = string.Empty,
				//		Genre = genre,
				//		PublishDate = DateTime.Now.Date,
				//	};

				//	HttpClient client = await GetClient();
				//	var response = await client.PostAsync(Url,
				//		new StringContent(
				//			JsonConvert.SerializeObject(book),
				//			Encoding.UTF8, "application/json"));

				//	return JsonConvert.DeserializeObject<Book>(
				//		await response.Content.ReadAsStringAsync());
				//}



				public async Task<LoginUser> Add(LoginUser loginUser)
				{
					// TODO: use POST to add a book
					//LoginUser book = new Book()
					//{
					//	Title = title,
					//	Authors = new List<string>(new[] { author }),
					//	ISBN = string.Empty,
					//	Genre = genre,
					//	PublishDate = DateTime.Now.Date,
					//};

					HttpClient client = await GetClient();
					var response = await client.PostAsync(Url,
						new StringContent(
							JsonConvert.SerializeObject(loginUser),
							Encoding.UTF8, "application/json"));

					return JsonConvert.DeserializeObject<LoginUser>(
						await response.Content.ReadAsStringAsync());
				}



				//public async Task Update(Book book)
				//{
				//	// TODO: use PUT to update a book
				//	HttpClient client = await GetClient();
				//	await client.PutAsync(Url + "/" + book.ISBN,
				//		new StringContent(
				//			JsonConvert.SerializeObject(book),
				//			Encoding.UTF8, "application/json"));
				//}


				//public async Task GetLoginUser(Book book)
				//{
				//	// TODO: use PUT to update a book
				//	HttpClient client = await GetClient();
				//	await client.PutAsync(Url + "/" + book.ISBN,
				//		new StringContent(
				//			JsonConvert.SerializeObject(book),
				//			Encoding.UTF8, "application/json"));
				//}



	}
	}
