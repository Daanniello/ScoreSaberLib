
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ScoreSaberLib.Models
{
    public class LeaderboardInfoModel
    {


        [JsonProperty("leaderboards")]
        public List<Leaderboard> Leaderboards { get; set; }

        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }


        public partial class Leaderboard
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
            public Difficulty Difficulty { get; set; }

            [JsonProperty("maxScore")]
            public long MaxScore { get; set; }

            [JsonProperty("createdDate")]
            public DateTimeOffset? CreatedDate { get; set; }

            [JsonProperty("rankedDate")]
            public object RankedDate { get; set; }

            [JsonProperty("qualifiedDate")]
            public object QualifiedDate { get; set; }

            [JsonProperty("lovedDate")]
            public object LovedDate { get; set; }

            [JsonProperty("ranked")]
            public bool Ranked { get; set; }

            [JsonProperty("qualified")]
            public bool Qualified { get; set; }

            [JsonProperty("loved")]
            public bool Loved { get; set; }

            [JsonProperty("maxPP")]
            public long MaxPp { get; set; }

            [JsonProperty("stars")]
            public long Stars { get; set; }

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
            public object Difficulties { get; set; }
        }

        public partial class Difficulty
        {
            [JsonProperty("leaderboardId")]
            public long LeaderboardId { get; set; }

            [JsonProperty("difficulty")]
            public long DifficultyDifficulty { get; set; }

            [JsonProperty("gameMode")]
            public string GameMode { get; set; }

            [JsonProperty("difficultyRaw")]
            public string DifficultyRaw { get; set; }
        }

        public partial class MetadataInfo
        {
            [JsonProperty("total")]
            public long Total { get; set; }

            [JsonProperty("page")]
            public long Page { get; set; }

            [JsonProperty("itemsPerPage")]
            public long ItemsPerPage { get; set; }
        }
    }
}


