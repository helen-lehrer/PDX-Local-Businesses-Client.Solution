using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using PdxLocalBusinessesClient.Models;
using System;

namespace PdxLocalBusinessesClient.Models
{
	class ApiHelper
	{
		public static async Task<string> GetAllBusinesses()
		{
      DotNetEnv.Env.Load();
      var apiKey = Environment.GetEnvironmentVariable("API_KEY");
			RestClient client = new RestClient("http://localhost:5000/api");
      client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
          apiKey, "Bearer"
      );
			RestRequest request = new RestRequest($"businesses", Method.GET);
			var response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}

		// public static async Task<string> Get(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"businesses/{id}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

		// public static async Task Post(string newBusiness)
		// {
		// 	RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"businesses", Method.POST);
		// 	request.AddHeader("Content-Type", "application/json");
		// 	request.AddJsonBody(newBusiness);
		// 	var response = await client.ExecuteTaskAsync(request);
		// }

		// public static async Task Put(int id, string newBusiness)
		// {
		// 	RestClient client = new RestClient("http://localhost:5000/api");
		// 	RestRequest request = new RestRequest($"businesses/{id}", Method.PUT);
		// 	request.AddHeader("Content-Type", "application/json");
		// 	request.AddJsonBody(newBusiness);
		// 	var response = await client.ExecuteTaskAsync(request);
		// }

		// public static async Task Delete(int id)
		// {
		// 	RestClient client = new RestClient("http://localhost:5000/api");
		// 	RestRequest request = new RestRequest($"businesses/{id}", Method.DELETE);
		// 	request.AddHeader("Content-Type", "application/json");
		// 	var response = await client.ExecuteTaskAsync(request);
		// }

		// //Groups
		// 	public static async Task<string> GroupGetAll()
		// {
		// 	RestClient client = new RestClient("http://localhost:5000/api");
		// 	RestRequest request = new RestRequest($"groups", Method.GET);
		// 	var response = await client.ExecuteTaskAsync(request);
		// 	return response.Content;
		// }

		// public static async Task<string> GroupGet(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"groups/{id}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

		// public static async Task GroupPost(string newGroup)
		// {
		// 	RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"groups", Method.POST);
		// 	request.AddHeader("Content-Type", "application/json");
		// 	request.AddJsonBody(newGroup);
		// 	var response = await client.ExecuteTaskAsync(request);
		// }

		// public static async Task GroupPut(int id, string newGroup)
		// {
		// 	RestClient client = new RestClient("http://localhost:5000/api");
		// 	RestRequest request = new RestRequest($"groups/{id}", Method.PUT);
		// 	request.AddHeader("Content-Type", "application/json");
		// 	request.AddJsonBody(newGroup);
		// 	var response = await client.ExecuteTaskAsync(request);
		// }

		// public static async Task GroupDelete(int id)
		// {
		// 	RestClient client = new RestClient("http://localhost:5000/api");
		// 	RestRequest request = new RestRequest($"groups/{id}", Method.DELETE);
		// 	request.AddHeader("Content-Type", "application/json");
		// 	var response = await client.ExecuteTaskAsync(request);
		// }
	}
}