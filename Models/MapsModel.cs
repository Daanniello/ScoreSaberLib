using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreSaberLib.Models
{
    public partial class MapsModel
    {
        [JsonProperty("scores")]
        public Score[] Scores { get; set; }
    }

    public partial class Score
    {
        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("scoreId")]
        public long ScoreId { get; set; }

        [JsonProperty("score")]
        public long ScoreScore { get; set; }

        [JsonProperty("unmodififiedScore")]
        public long UnmodififiedScore { get; set; }

        [JsonProperty("mods")]
        public string Mods { get; set; }

        [JsonProperty("pp")]
        public double Pp { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("timeSet")]
        public DateTimeOffset TimeSet { get; set; }

        [JsonProperty("leaderboardId")]
        public long LeaderboardId { get; set; }

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
    }
}
