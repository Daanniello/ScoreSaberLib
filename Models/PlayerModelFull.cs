using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ScoreSaberLib.Models
{
    public partial class PlayerModelFull
    {
        [JsonProperty("playerInfo")]
        public PlayerInfoFull PlayerInfo { get; set; }

        [JsonProperty("scoreStats")]
        public ScoreStats ScoreStats { get; set; }
    }

    public partial class PlayerInfoFull
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
        public string Role { get; set; }

        [JsonProperty("badges")]
        public Badge[] Badges { get; set; }

        [JsonProperty("history")]
        public string History { get; set; }

        [JsonProperty("permissions")]
        public long Permissions { get; set; }

        [JsonProperty("inactive")]
        public long Inactive { get; set; }

        [JsonProperty("banned")]
        public long Banned { get; set; }
    }

    public partial class Badge
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class ScoreStats
    {
        [JsonProperty("totalScore")]
        public long TotalScore { get; set; }

        [JsonProperty("totalRankedScore")]
        public long TotalRankedScore { get; set; }

        [JsonProperty("averageRankedAccuracy")]
        public double AverageRankedAccuracy { get; set; }

        [JsonProperty("totalPlayCount")]
        public long TotalPlayCount { get; set; }

        [JsonProperty("rankedPlayCount")]
        public long RankedPlayCount { get; set; }
    }
}
