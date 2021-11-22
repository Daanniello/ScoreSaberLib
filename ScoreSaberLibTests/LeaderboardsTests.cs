using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreSaberLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSaberLibTests
{
    [TestClass]
    public class LeaderboardsTests
    {
        [TestMethod]
        public void leaderboardsByFilter()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var leaderboardInfo = await scoreSaberClient.Api.Leaderboards.GetLeaderboardsByFilter(ranked: true, qualified: true, loved: true, minStar: 0, maxStar: 20, category: Leaderboards.Category.starDifficulty, sort: Leaderboards.Sort.ascending, unique: true);
                //TODO MORE ASSERTS
                Assert.IsTrue(leaderboardInfo.TotalCount > 0);               
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void leaderboardInfoByID()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var leaderboard = await scoreSaberClient.Api.Leaderboards.GetLeaderboardInfoByID(394355);
                //TODO MORE ASSERTS
                Assert.IsTrue(leaderboard.Id == 394355);
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void leaderboardInfoByHashcode()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var leaderboard = await scoreSaberClient.Api.Leaderboards.GetLeaderboardInfoByHashcode("D13D74987C4095E5064B91D2963A96D06561962B", Leaderboards.Difficulty.expert);
                var leaderboardFail = await scoreSaberClient.Api.Leaderboards.GetLeaderboardInfoByHashcode("D13D74987C4095E5064B91D2963A96D06561962B", Leaderboards.Difficulty.hard);
                //TODO MORE ASSERTS
                Assert.IsTrue(leaderboard.SongHash == "D13D74987C4095E5064B91D2963A96D06561962B");
                Assert.IsTrue(leaderboard.Difficulty == 7);
                Assert.IsTrue(leaderboardFail == null);
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void leaderboardScoresByID()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var leaderboard = await scoreSaberClient.Api.Leaderboards.GetLeaderboardScoresByID(394355, countryCodes: "NL", search: "TheJumpingSheep", page: 1);
                //TODO MORE ASSERTS
                Assert.IsTrue(leaderboard.First().Id == 63450817);
                Assert.IsTrue(leaderboard.First().LeaderboardPlayerInfo.Id == "3067073569973129");
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void leaderboardScoresByHashcode()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var leaderboard = await scoreSaberClient.Api.Leaderboards.GetLeaderboardScoresByHashcode("D13D74987C4095E5064B91D2963A96D06561962B", Leaderboards.Difficulty.expertplus);
                //TODO MORE ASSERTS
                Assert.IsTrue(leaderboard.First().Rank == 1);
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void leaderboardDifficulties()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var leaderboard = await scoreSaberClient.Api.Leaderboards.GetLeaderboardDifficultiesByHashcode("D13D74987C4095E5064B91D2963A96D06561962B");
                //TODO MORE ASSERTS
                Assert.IsTrue(leaderboard.First().LeaderboardId == 394359);
                Assert.IsTrue(leaderboard[1].LeaderboardId == 394355);
                Assert.IsTrue(leaderboard.First().DifficultyType == 7);
            }).GetAwaiter().GetResult();
        }
    }
}
