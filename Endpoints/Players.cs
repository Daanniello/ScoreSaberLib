using ScoreSaberLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Task<PlayerInfoModel> GetPlayers(string search = null, int? page = null, string countryCodes = null)
        {
            var extraStatement = "?";
            if (search != null) extraStatement += $"search={search}&";
            if (page != null) extraStatement += $"page={page}&";
            if (countryCodes != null) extraStatement += $"countries={countryCodes}&";

            return Get<PlayerInfoModel>($"/players{extraStatement}");
        }

        /// <summary>
        /// Gets the count of players possibly based on filters
        /// </summary>
        /// <param name="search"></param>
        /// <param name="countryCodes">example: NL, IE, FR</param>
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
        /// <param name="ID">The player Scoresaber ID</param>
        /// <returns>PlayerInfo or null</returns>
        public Task<PlayerInfoModel.Player> GetPlayer(long ID)
        {
            return Get<PlayerInfoModel.Player>($"/player/{ID}/full");
        }

        /// <summary>
        /// Gets scores by player ID with sorts
        /// </summary>
        /// <param name="ID">The player Scoresaber ID</param>
        /// <param name="limit">The amount you want to retrieve for each page (100 is the max for each page)</param>
        /// <param name="sort">Top song page or recent song page</param>
        /// <param name="page">The page number you want to retrieve (normally each page is 8 maps)</param>
        /// <returns></returns>
        public async Task<List<PlayerScoresModel.PlayerScore>> GetPlayerScores(long ID, int? limit = null, sort? sort = null, int? page = null)
        {
            var extraStatement = "?";
            if (limit != null) extraStatement += $"limit={limit}&";
            if (sort != null) extraStatement += $"sort={sort}&";
            if (page != null) extraStatement += $"page={page}&";

            var result = await Get<PlayerScoresModel>($"/player/{ID}/scores{extraStatement}");
            return result.PlayerScores;
        }

        /// <summary>
        /// Gets a players recent or top score info by count. Example: count 3 will return the third last played map or top play from the player.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="sort"></param>
        /// <param name="count">The count of the map to retrieve. count = 3 for example will return the third most recent played map</param>
        /// <returns></returns>
        public async Task<PlayerScoresModel.PlayerScore> GetPlayerScoreByCount(long ID, int count, sort? sort = null)
        {
            count -= 1;
            if (count < 0) count = 0;
            var page = Math.DivRem(count, 8, out int nr);
            if (nr == 0)
            {
                page -= 1;
                nr += 8;
            }

            var extraStatement = "?";
            if (sort != null) extraStatement += $"sort={sort}&";
            extraStatement += $"page={page + 1}&";


            var result = await Get<PlayerScoresModel>($"/player/{ID}/scores{extraStatement}");
            return result.PlayerScores[count == 0 ? count : nr];
        }

        public enum sort
        {
            top,
            recent
        }
    }
}
