using ScoreSaberLib.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreSaberLib
{
	public class Leaderboards : Endpoint
	{
		public Leaderboards()
		{

		}

		/// <summary>
		/// Sorts Leaderboards by filter
		/// </summary>
		/// <param name="ranked"></param>
		/// <param name="qualified"></param>
		/// <param name="loved"></param>
		/// <param name="minStar"></param>
		/// <param name="maxStar"></param>
		/// <param name="category"></param>
		/// <param name="sort"></param>
		/// <param name="unique"></param>
		/// <returns>LeaderboardMapsModel.Leaderboards or Null</returns>
		public async Task<LeaderboardInfoModel> GetLeaderboardsByFilter(bool? ranked = null, bool? qualified = null, bool? loved = null, int? minStar = null, int? maxStar = null, Category? category = null, Sort? sort = null, bool? unique = null)
		{
			var extraStatement = "?";
			if (ranked != null) extraStatement += $"ranked={ranked}&";
			if (qualified != null) extraStatement += $"qualified={qualified}&";
			if (loved != null) extraStatement += $"loved={loved}&";
			if (minStar != null) extraStatement += $"minStar={minStar}&";
			if (maxStar != null) extraStatement += $"maxStar={maxStar}&";
			if (category != null) extraStatement += $"category={(int)category}&";
			if (sort != null) extraStatement += $"sort={(int)sort}&";
			if (unique != null) extraStatement += $"unique={unique}&";

			var result = await Get<LeaderboardInfoModel> ($"/leaderboards{extraStatement}");
			return result;
		}

		/// <summary>
		/// Gives a certain leaderboard's Info by ID 
		/// </summary>
		/// <param name="ID"></param>
		/// <returns>LeaderboardModel or Null</returns>
		public async Task<Models.LeaderboardInfoModel.Leaderboard> GetLeaderboardInfoByID(int ID)
		{
			var result = await Get<Models.LeaderboardInfoModel.Leaderboard>($"/leaderboard/by-id/{ID}/info");
			return result;
        }

		/// <summary>
		///  gives leaderboard scores by id and posibly filters
		/// </summary>
		/// <param name="ID"></param>
		/// <param name="countryCode"></param>
		/// <param name="search"></param>
		/// <param name="page"></param>
		/// <returns>list of LeaderboardScores or null</returns>
		public async Task<List<Models.LeaderboardScoresModel.Score>> GetLeaderboardScoresByID(int ID, string countryCodes = null, string search = null, int? page = null)
		{
			var extraStatement = "?";
			if (countryCodes != null) extraStatement += $"countries={countryCodes}&";
			if (search != null) extraStatement += $"search={search}&";
			if (page != null) extraStatement += $"page={page}&";

			var result = await Get<Models.LeaderboardScoresModel>($"/leaderboard/by-id/{ID}/scores{extraStatement}");
			return result.Scores;
		}

		/// <summary>
		/// gives leaderboard info by hashcode
		/// </summary>
		/// <param name="hashCode"></param>
		/// <param name="difficulty"></param>
		/// <returns>LeaderboardInfo or null</returns>
		public async Task<Models.LeaderboardInfoModel.Leaderboard> GetLeaderboardInfoByHashcode(string hashCode, Difficulty difficulty)
		{
			var result = await Get<Models.LeaderboardInfoModel.Leaderboard>($"/leaderboard/by-hash/{hashCode}/info?difficulty={(int)difficulty}");
			return result;
		}

		/// <summary>
		/// gives leaderboard scores by hashcode with possible filters
		/// </summary>
		/// <param name="hashCode"></param>
		/// <param name="difficulty"></param>
		/// <param name="countryCode"></param>
		/// <param name="search"></param>
		/// <param name="page"></param>
		/// <returns>list of LeaderboardScores or null</returns>
		public async Task<List<Models.LeaderboardScoresModel.Score>> GetLeaderboardScoresByHashcode(string hashCode, Difficulty difficulty, string countryCodes = null, string search = null, int? page = null)
		{
			var extraStatement = $"?difficulty={(int)difficulty}&";
			if (countryCodes != null) extraStatement += $"countries={countryCodes}&";
			if (search != null) extraStatement += $"search={search}&";
			if (page != null) extraStatement += $"page={page}&";

			var result = await Get<Models.LeaderboardScoresModel>($"/leaderboard/by-hash/{hashCode}/scores{extraStatement}");
			return result.Scores;
		}

		/// <summary>
		/// Gives difficulties from a map leaderboard by hashcode
		/// </summary>
		/// <param name="hashCode"></param>
		/// <returns>List of difficulty or null</returns>
		public Task<List<Models.LeaderboardInfoModel.Difficulty>> GetLeaderboardDifficultiesByHashcode(string hashCode)
		{
			return Get<List<Models.LeaderboardInfoModel.Difficulty>>($"/leaderboard/get-difficulties/{hashCode}");
		}

		public enum Category 
		{ 
			trending = 0,
			dateRanked = 1,
			scoresSet = 2,
			starDifficulty = 3,
			author = 4
		}

		public enum Sort
		{
			descending = 0,
			ascending = 1
		}

		public enum Difficulty
        {
			easy = 1,
			normal = 3,
			hard = 5,
			expert = 7,
			expertplus = 9
        }

	}
}
