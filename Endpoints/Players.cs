using Newtonsoft.Json;
using ScoreSaberLib.Models;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


namespace ScoreSaberLib
{
    public class Players
    {
        public Players()
        {

        }

        /// <summary>
        /// Returns a list of players with minimal info.
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns>PlayersModel or null</returns>
        public async Task<PlayersModel> ByName(string playerName)
        {
            using (var client = new HttpClient())
            {
                PlayersModel players = null;
                HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/players/by-name/{playerName}");
                if (response.IsSuccessStatusCode)
                {
                    players = JsonConvert.DeserializeObject<PlayersModel>(await response.Content.ReadAsStringAsync());               
                }
                return players;
            }
        }

        /// <summary>
        /// Returns a players full info 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>PlayerModelFull or Null</returns>
        public async Task<PlayerModelFull> ByIDFull(ulong ID)
        {
            using (var client = new HttpClient())
            {
                PlayerModelFull players = null;
                HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/player/{ID}/full");
                if (response.IsSuccessStatusCode)
                {
                    players = JsonConvert.DeserializeObject<PlayerModelFull>(await response.Content.ReadAsStringAsync());
                }
                return players;
            }
        }

        /// <summary>
        /// Returns a players basic info 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>PlayerModelBasic or Null</returns>
        public async Task<PlayerModelBasic> ByIDBasic(ulong ID)
        {
            using (var client = new HttpClient())
            {
                PlayerModelBasic players = null;
                HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/player/{ID}/basic");
                if (response.IsSuccessStatusCode)
                {
                    players = JsonConvert.DeserializeObject<PlayerModelBasic>(await response.Content.ReadAsStringAsync());
                }
                return players;
            }
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

        /// <summary>
        /// Gets the recent maps played from a user. Only 8 maps each page.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="page"></param>
        /// <returns>MapsModel or Null</returns>
        public async Task<MapsModel> GetRecentSongs(ulong ID, int page)
        {
            using (var client = new HttpClient())
            {
                MapsModel recentMaps = null;
                HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/player/{ID}/scores/recent/{page}");
                if (response.IsSuccessStatusCode)
                {
                    recentMaps = JsonConvert.DeserializeObject<MapsModel>(await response.Content.ReadAsStringAsync());
                }
                return recentMaps;
            }
        }

        /// <summary>
        /// Gets the top maps played from a user. Only 8 maps each page.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="page"></param>
        /// <returns>MapsModel or Null</returns>
        public async Task<MapsModel> GetTopSongs(ulong ID, int page)
        {
            using (var client = new HttpClient())
            {
                MapsModel topMaps = null;
                HttpResponseMessage response = await client.GetAsync($"https://new.scoresaber.com/api/player/{ID}/scores/top/{page}");
                if (response.IsSuccessStatusCode)
                {
                    topMaps = JsonConvert.DeserializeObject<MapsModel>(await response.Content.ReadAsStringAsync());
                }
                return topMaps;
            }
        }
    }
}
