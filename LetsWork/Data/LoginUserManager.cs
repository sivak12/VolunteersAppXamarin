using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

				//client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
				client.DefaultRequestHeaders.Add("Accept", "application/json");
				return client;
			}


		
			public async Task<LoginUser> Add(LoginUser loginUser)
			{
				HttpClient client = await GetClient();
				var response = await client.PostAsync(Url,
					new StringContent(
						JsonConvert.SerializeObject(loginUser),
						Encoding.UTF8, "application/json"));

				return JsonConvert.DeserializeObject<LoginUser>(
					await response.Content.ReadAsStringAsync());
			}



	public async Task<IEnumerable<Task>> GetAll()
	{
		HttpClient client = await GetClient();
		string result = await client.GetStringAsync(Url);
		return JsonConvert.DeserializeObject<IEnumerable<Task>>(result);
	}


	public async Task<LoginUser> CheckUser(LoginUser loginUser)
	{
        // TODO: use PUT to update a book
        HttpClient client = await GetClient();

        var response = await client.PutAsync(Url + "username/" + loginUser.Username ,
			new StringContent(
				JsonConvert.SerializeObject(loginUser),
				Encoding.UTF8, "application/json"));

		return JsonConvert.DeserializeObject<LoginUser>(
			await response.Content.ReadAsStringAsync());
    }




}
}
