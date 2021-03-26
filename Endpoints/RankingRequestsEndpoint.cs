using ScoreSaberLib.Models;
using System.Threading.Tasks;

namespace ScoreSaberLib
{
	public class RankingRequestsEndpoint : Endpoint
	{
		public RankingRequestsEndpoint()
		{

		}

		/// <summary>
		/// Gets the requested ranked maps that are going for ranked and are in the queue. 
		/// In queue means that they are almost going to be qualified.
		/// </summary>
		/// <returns>RankedRequestMapsModel or Null</returns>
		public Task<RankedRequestMapsModel> GetNextInQueue()
		{
			return Get<RankedRequestMapsModel>($"/ranking/requests/top");
		}

		/// <summary>
		/// Gets the requested ranked maps that are not in queue yet. They are yet to be reviewed and get into the top queue.
		/// </summary>
		/// <returns>RankedRequestMapsModel or Null</returns>
		public Task<RankedRequestMapsModel> GetOpenRequests()
		{
			return Get<RankedRequestMapsModel>($"/ranking/requests/belowTop");
		}
	}
}
