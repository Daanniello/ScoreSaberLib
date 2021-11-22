using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ScoreSaberLib.Models
{
    public class LeaderboardScoresModel
    {

        public partial class LeaderboardScores
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
            public double Pp { get; set; }

            [JsonProperty("weight")]
            public double Weight { get; set; }

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
            public long FullCombo { get; set; }

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
            public string Role { get; set; }
        }
    }
}
