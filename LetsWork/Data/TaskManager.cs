using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LetsWork
{
    public class TaskManager
    {

        const string Url = "http://letswork.azurewebsites.net/api/task/";

		private async Task<HttpClient> GetClient()
		{
			HttpClient client = new HttpClient();
			

           //if (string.IsNullOrEmpty(authorizationKey))
			//{
			//	authorizationKey = await client.GetStringAsync(Url + "login");
			//	authorizationKey = JsonConvert.DeserializeObject<string>(authorizationKey);
			//}

			//client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			return client;
		}


		public async Task<IEnumerable<Task>> GetAll()
		{
			HttpClient client = await GetClient();
			string result = await client.GetStringAsync(Url);
			return JsonConvert.DeserializeObject<IEnumerable<Task>>(result);
		}

    }
}
