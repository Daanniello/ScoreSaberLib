using Newtonsoft.Json;
using ScoreSaberLib.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSaberLib
{
    public class Leaderboards
    {
        public Leaderboards()
        {

        }

        /// <summary>
        /// Gets 50 minimal player data from a certain page
        /// Will return a list of 50
        /// </summary>
        /// <param name="page"></param>
        /// <returns>PlayersModel or null</returns>
        public async Task<PlayersModel> GetGlobal(int page)
        {
            using (var client = new HttpClient())
            {
                PlayersModel players = null;
                HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/players/{page}");
                if (response.IsSuccessStatusCode)
                {
                    players = JsonConvert.DeserializeObject<PlayersModel>(await response.Content.ReadAsStringAsync());
                }
                return players;
            }
        }
    }
}
