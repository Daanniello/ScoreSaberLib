
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ScoreSaberLib.Models
{
    public class LeaderboardInfoModel
    {

        public partial class Leaderboards
        {
            [JsonProperty("leaderboards")]
            public List<LeaderboardInfo> LeaderboardsList { get; set; }

            [JsonProperty("totalCount")]
            public long TotalCount { get; set; }
        }

        public partial class LeaderboardInfo
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("songHash")]
            public string SongHash { get; set; }

            [JsonProperty("songName")]
            public string SongName { get; set; }

            [JsonProperty("songSubName")]
            public string SongSubName { get; set; }

            [JsonProperty("songAuthorName")]
            public string SongAuthorName { get; set; }

            [JsonProperty("levelAuthorName")]
            public string LevelAuthorName { get; set; }

            [JsonProperty("difficulty")]
            public long Difficulty { get; set; }

            [JsonProperty("difficultyRaw")]
            public string DifficultyRaw { get; set; }

            [JsonProperty("maxScore")]
            public long MaxScore { get; set; }

            [JsonProperty("createdDate")]
            public DateTimeOffset CreatedDate { get; set; }

            [JsonProperty("rankedDate")]
            public long RankedDate { get; set; }

            [JsonProperty("qualifiedDate")]
            public long QualifiedDate { get; set; }

            [JsonProperty("lovedDate")]
            public long LovedDate { get; set; }

            [JsonProperty("ranked")]
            public long Ranked { get; set; }

            [JsonProperty("qualified")]
            public long Qualified { get; set; }

            [JsonProperty("loved")]
            public long Loved { get; set; }

            [JsonProperty("maxPP")]
            public long MaxPp { get; set; }

            [JsonProperty("stars")]
            public double Stars { get; set; }

            [JsonProperty("plays")]
            public long Plays { get; set; }

            [JsonProperty("dailyPlays")]
            public long DailyPlays { get; set; }

            [JsonProperty("positiveModifiers")]
            public bool PositiveModifiers { get; set; }

            [JsonProperty("playerScore")]
            public object PlayerScore { get; set; }

            [JsonProperty("coverImage")]
            public Uri CoverImage { get; set; }

            [JsonProperty("difficulties")]
            public List<Difficulty> Difficulties { get; set; }
        }

        public partial class Difficulty
        {
            [JsonProperty("leaderboardId")]
            public long LeaderboardId { get; set; }

            [JsonProperty("difficulty")]
            public long DifficultyType { get; set; }
        }
    }
}

