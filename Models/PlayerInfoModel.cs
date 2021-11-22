﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ScoreSaberLib.Models
{
    public class PlayerInfoModel
    {

        public partial class PlayerInfo
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("profilePicture")]
            public Uri ProfilePicture { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("pp")]
            public double Pp { get; set; }

            [JsonProperty("rank")]
            public long Rank { get; set; }

            [JsonProperty("countryRank")]
            public long CountryRank { get; set; }

            [JsonProperty("role")]
            public string Role { get; set; }

            [JsonProperty("badges")]
            public List<Badge> Badges { get; set; }

            [JsonProperty("histories")]
            public string Histories { get; set; }

            [JsonProperty("permissions")]
            public long Permissions { get; set; }

            [JsonProperty("banned")]
            public long Banned { get; set; }

            [JsonProperty("inactive")]
            public long Inactive { get; set; }

            [JsonProperty("scoreStats")]
            public ScoreStats ScoreStats { get; set; }
        }

        public partial class Badge
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("image")]
            public Uri Image { get; set; }
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

            [JsonProperty("replaysWatched")]
            public long ReplaysWatched { get; set; }
        }
    }
}
