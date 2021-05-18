using ScoreSaberLib.Models;
using System.Net.Http;
using System.Threading.Tasks;


namespace ScoreSaberLib
{
	public class Players : Endpoint
	{
		public Players()
		{

		}

		/// <summary>
		/// Returns a list of players with minimal info.
		/// </summary>
		/// <param name="playerName"></param>
		/// <returns>PlayersModel or null</returns>
		public Task<PlayersModel> ByName(string playerName)
		{
			return Get<PlayersModel>($"/players/by-name/{playerName}");
		}

		/// <summary>
		/// Returns a players full info 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns>PlayerModelFull or Null</returns>
		public Task<PlayerModelFull> ByIDFull(ulong ID)
		{
			return Get<PlayerModelFull>($"/player/{ID}/full");
		}

		/// <summary>
		/// Returns a players basic info 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns>PlayerModelBasic or Null</returns>
		public Task<PlayerModelBasic> ByIDBasic(ulong ID)
		{
			return Get<PlayerModelBasic>($"/player/{ID}/basic");
		}

		/// <summary>
		/// Gets the recent maps played from a user. Only 8 maps each page.
		/// </summary>
		/// <param name="ID"></param>
		/// <param name="page"></param>
		/// <returns>MapsModel or Null</returns>
		public Task<MapsModel> GetRecentSongs(ulong ID, int page)
		{
			return Get<MapsModel>($"/player/{ID}/scores/recent/{page}");
		}

		/// <summary>
		/// Gets the top maps played from a user. Only 8 maps each page.
		/// </summary>
		/// <param name="ID"></param>
		/// <param name="page"></param>
		/// <returns>MapsModel or Null</returns>
		public Task<MapsModel> GetTopSongs(ulong ID, int page)
		{
			return Get<MapsModel>($"/player/{ID}/scores/top/{page}");
		}

		/// <summary>
		/// Gets the url of an avatar from a user
		/// </summary>
		/// <param name="ID"></param>
		/// <returns>string</returns>
		public async Task<string> GetAvatar(ulong ID)
		{
			using (var client = new HttpClient())
			{
				string avatar = null;
				HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/static/avatars/{ID}.jpg");
				if (response.IsSuccessStatusCode)
				{
					avatar = $"https://new.scoresaber.com/api/static/avatars/{ID}.jpg";
				}
				return avatar;
			}
		}
	}
}
