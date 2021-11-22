using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreSaberLib.Models
{
    public class RankRequestModel
    {

        public partial class Request
        {
            [JsonProperty("requestId")]
            public long RequestId { get; set; }

            [JsonProperty("requestDescription")]
            public string RequestDescription { get; set; }

            [JsonProperty("leaderboardInfo")]
            public LeaderboardInfo LeaderboardInfo { get; set; }

            [JsonProperty("created_at")]
            public DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("rankVotes")]
            public Votes RankVotes { get; set; }

            [JsonProperty("qatVotes")]
            public Votes QatVotes { get; set; }

            [JsonProperty("rankComments")]
            public List<RankComment> RankComments { get; set; }

            [JsonProperty("qatComments")]
            public List<object> QatComments { get; set; }

            [JsonProperty("requestType")]
            public long RequestType { get; set; }

            [JsonProperty("approved")]
            public long Approved { get; set; }

            [JsonProperty("difficulties")]
            public List<Difficulty> Difficulties { get; set; }
        }

        public partial class Difficulty
        {
            [JsonProperty("requestId")]
            public long RequestId { get; set; }

            [JsonProperty("difficulty")]
            public long DifficultyDifficulty { get; set; }
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
            public double MaxPp { get; set; }

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
            public object Difficulties { get; set; }
        }

        public partial class Votes
        {
            [JsonProperty("upvotes")]
            public long Upvotes { get; set; }

            [JsonProperty("downvotes")]
            public long Downvotes { get; set; }

            [JsonProperty("myVote")]
            public bool MyVote { get; set; }

            [JsonProperty("neutral")]
            public long Neutral { get; set; }
        }

        public partial class RankComment
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("userId")]
            public object UserId { get; set; }

            [JsonProperty("comment")]
            public string Comment { get; set; }

            [JsonProperty("timeStamp")]
            public DateTimeOffset TimeStamp { get; set; }
        }
    }

}

