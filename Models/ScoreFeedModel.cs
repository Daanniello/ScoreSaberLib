using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreSaberLib.Models
{
    public partial class ScoreFeedModel : EventArgs
    {
        [JsonProperty("commandName")]
        public string CommandName { get; set; }

        [JsonProperty("commandData")]
        public CommandData CommandData { get; set; }
    }

    public partial class CommandData
    {
        [JsonProperty("score")]
        public Score Score { get; set; }

        [JsonProperty("leaderboard")]
        public Leaderboard Leaderboard { get; set; }
    }

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

    public partial class Score
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("leaderboardPlayerInfo")]
        public LeaderboardPlayerInfo LeaderboardPlayerInfo { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("baseScore")]
        public long BaseScore { get; set; }

        [JsonProperty("modifiedScore")]
        public long ModifiedScore { get; set; }

        [JsonProperty("pp")]
        public long Pp { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("modifiers")]
        public string Modifiers { get; set; }

        [JsonProperty("multiplier")]
        public long Multiplier { get; set; }

        [JsonProperty("badCuts")]
        public long BadCuts { get; set; }

        [JsonProperty("missedNotes")]
        public long MissedNotes { get; set; }

        [JsonProperty("maxCombo")]
        public long MaxCombo { get; set; }

        [JsonProperty("fullCombo")]
        public bool FullCombo { get; set; }

        [JsonProperty("hmd")]
        public long Hmd { get; set; }

        [JsonProperty("timeSet")]
        public DateTimeOffset TimeSet { get; set; }

        [JsonProperty("hasReplay")]
        public bool HasReplay { get; set; }
    }

    public partial class LeaderboardPlayerInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profilePicture")]
        public Uri ProfilePicture { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("permissions")]
        public long Permissions { get; set; }

        [JsonProperty("badges")]
        public string Badges { get; set; }

        [JsonProperty("role")]
        public object Role { get; set; }
    }
}
