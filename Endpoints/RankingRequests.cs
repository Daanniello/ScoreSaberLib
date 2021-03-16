using Newtonsoft.Json;
using ScoreSaberLib.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSaberLib
{
    public class RankingRequests
    {
        public RankingRequests()
        {

        }

        /// <summary>
        /// Gets the requested ranked maps that are going for ranked and are in the queue. 
        /// In queue means that they are almost going to be qualified.
        /// </summary>
        /// <returns>RankedRequestMapsModel or Null</returns>
        public async Task<RankedRequestMapsModel> GetNextInQueue()
        {
            using (var client = new HttpClient())
            {
                RankedRequestMapsModel requestMaps = null;
                HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/ranking/requests/top");
                if (response.IsSuccessStatusCode)
                {
                    requestMaps = JsonConvert.DeserializeObject<RankedRequestMapsModel>(await response.Content.ReadAsStringAsync());
                }
                return requestMaps;
            }
        }

        /// <summary>
        /// Gets the requested ranked maps that are not in queue yet. They are yet to be reviewed and get into the top queue.
        /// </summary>
        /// <returns>RankedRequestMapsModel or Null</returns>
        public async Task<RankedRequestMapsModel> GetOpenRequests()
        {
            using (var client = new HttpClient())
            {
                RankedRequestMapsModel requestMaps = null;
                HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/ranking/requests/belowTop");
                if (response.IsSuccessStatusCode)
                {
                    requestMaps = JsonConvert.DeserializeObject<RankedRequestMapsModel>(await response.Content.ReadAsStringAsync());
                }
                return requestMaps;
            }
        }
    }
}
