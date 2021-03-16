using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreSaberLib.Models
{
    public partial class PlayerModelBasic
    {
        [JsonProperty("playerInfo")]
        public PlayerInfoBasic PlayerInfo { get; set; }
    }

    public partial class PlayerInfoBasic
    {
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("playerName")]
        public string PlayerName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("countryRank")]
        public long CountryRank { get; set; }

        [JsonProperty("pp")]
        public double Pp { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("role")]
        public object Role { get; set; }

        [JsonProperty("badges")]
        public object[] Badges { get; set; }

        [JsonProperty("history")]
        public string History { get; set; }

        [JsonProperty("permissions")]
        public long Permissions { get; set; }

        [JsonProperty("inactive")]
        public long Inactive { get; set; }

        [JsonProperty("banned")]
        public long Banned { get; set; }
    }
}
