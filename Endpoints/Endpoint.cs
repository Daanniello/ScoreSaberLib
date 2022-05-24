using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScoreSaberLib
{
	public abstract class Endpoint
	{
		readonly string baseURL = "https://scoresaber.com/api";

		protected async Task<T> Get<T>(string endpoint)
		{
			using (var client = new HttpClient())
			{
				HttpResponseMessage response = await client.GetAsync($"{baseURL}{endpoint.Replace("True", "true")}");
				if (!response.IsSuccessStatusCode)
				{
					return default(T);
				}
				return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());

			}
		}
	}
}
