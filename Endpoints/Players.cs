using ScoreSaberLib.Models;
using System.Collections.Generic;
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
        /// Gets a list of players possibly based on filters
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <param name="countryCodes"></param>
        /// <returns>list of PlayerInfo or null</returns>
        public Task<List<PlayerInfoModel.PlayerInfo>> GetPlayers(string search = null, int? page = null, string countryCodes = null)
        {
            var extraStatement = "?";
            if (search != null) extraStatement += $"search={search}&";
            if (page != null) extraStatement += $"page={page}&";
            if (countryCodes != null) extraStatement += $"countries={countryCodes}&";

            return Get< List<PlayerInfoModel.PlayerInfo>>($"/players{extraStatement}");
        }

        /// <summary>
        /// Gets the count of players possibly based on filters
        /// </summary>
        /// <param name="search"></param>
        /// <param name="countryCodes"></param>
        /// <returns>int or null</returns>
        public Task<int> GetPlayersCount(string search = null, string countryCodes = null)
        {
            var extraStatement = "?";
            if (search != null) extraStatement += $"search={search}&";
            if (countryCodes != null) extraStatement += $"countries={countryCodes}&";

            return Get<int>($"/players/count{extraStatement}");
        }

        /// <summary>
        /// Gets all the players info based on ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>PlayerInfo or null</returns>
        public Task<PlayerInfoModel.PlayerInfo> GetPlayer(long ID)
        {
            return Get<PlayerInfoModel.PlayerInfo>($"/player/{ID}/full");
        }

        /// <summary>
        /// Gets scores by player ID with sorts
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="limit"></param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public Task<List<PlayerScoresModel.PlayerScore>> GetPlayerScores(long ID, int? limit = null, sort? sort = null, int? page = null)
        {
            var extraStatement = "?";
            if (limit != null) extraStatement += $"limit={limit}&";
            if (sort != null) extraStatement += $"sort={sort}&";
            if (page != null) extraStatement += $"page={page}&";

            return Get<List<PlayerScoresModel.PlayerScore>>($"/player/{ID}/scores{extraStatement}");
        }

        public enum sort
        {
            top,
            recent
        }
    }
}
