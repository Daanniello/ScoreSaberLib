using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ScoreSaberLib.Models
{
    public partial class PlayersModel
    {
        [JsonProperty("players")]
        public Player[] Players { get; set; }
    }

    public partial class Player
    {
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("playerName")]
        public string PlayerName { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("pp")]
        public double Pp { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("history")]
        public string History { get; set; }

        [JsonProperty("difference")]
        public long Difference { get; set; }
    }
}
