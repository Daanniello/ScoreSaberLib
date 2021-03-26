using ScoreSaberLib.Models;
using System.Threading.Tasks;

namespace ScoreSaberLib
{
	public class LeaderboardsEndpoint : Endpoint
	{
		public LeaderboardsEndpoint()
		{

		}

		/// <summary>
		/// Gets 50 minimal player data from a certain page
		/// Will return a list of 50
		/// </summary>
		/// <param name="page"></param>
		/// <returns>PlayersModel or null</returns>
		public Task<PlayersModel> GetGlobal(int page)
		{
			return Get<PlayersModel>($"/players/{page}");
		}
	}
}
