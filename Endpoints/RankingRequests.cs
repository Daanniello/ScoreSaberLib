using ScoreSaberLib.Models;
using System.Threading.Tasks;

namespace ScoreSaberLib
{
	public class RankingRequests : Endpoint
	{
		public RankingRequests()
		{

		}

        /// <summary>
        /// Gets rank request information by requestID
        /// </summary>
        /// <param name="requestID"></param>
        /// <returns>RankRequestModel.Request or null</returns>
        public Task<Models.RankRequestModel.Request> GetRequest(long requestID)
        {
            return Get<Models.RankRequestModel.Request>($"/ranking/request/{requestID}");
        }

        public Task<Models.RankRequestModel.Request> GetRequestByLeaderboardID(long leaderboardID)
        {
            return Get<Models.RankRequestModel.Request>($"/ranking/request/by-id/{leaderboardID}");
        }
    }
}
