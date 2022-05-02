using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreSaberLib;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreSaberLibTests
{
    [TestClass]
    public class PlayersTests
    {
        [TestMethod]
        public void GetPlayers()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var player = await scoreSaberClient.Api.Players.GetPlayers(search: "silverhaze", page: 1, countryCodes: "NL");
                var players = new List<ScoreSaberLib.Models.PlayerInfoModel.Player>();
                for (var i = 0; i < 3; i++)
                {
                    var playersData = await scoreSaberClient.Api.Players.GetPlayers(page: i + 1);
                    players.AddRange(playersData.Players);
                }

                Assert.IsTrue(players.Count == 150);
                Assert.IsTrue(players != null);
                Assert.IsTrue(player.Players.First().Name == "Silverhaze");
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void GetPlayersCount()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var playercount = await scoreSaberClient.Api.Players.GetPlayersCount(search: "silverhaze", countryCodes: "NL");
                Assert.IsTrue(playercount == 1);
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void GetPlayer()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var player = await scoreSaberClient.Api.Players.GetPlayer(76561198033166451);
                Assert.IsTrue(player.Id == "76561198033166451");
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void GetPlayerScores()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var playerscores = await scoreSaberClient.Api.Players.GetPlayerScores(76561198180044686, limit: 10, sort: Players.sort.top, page: 1);
                Assert.IsTrue(playerscores.First() != null);
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void GetPlayerScoreByCount()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var playerscoresPage1 = await scoreSaberClient.Api.Players.GetPlayerScores(76561198180044686, limit: 10, sort: Players.sort.top, page: 1);
                var playerscoresPageRecent1 = await scoreSaberClient.Api.Players.GetPlayerScores(76561198180044686, limit: 10, sort: Players.sort.recent, page: 1);
                var playerscoresPage2 = await scoreSaberClient.Api.Players.GetPlayerScores(76561198180044686, sort: Players.sort.top, page: 2);
                var playerscore1 = await scoreSaberClient.Api.Players.GetPlayerScoreByCount(76561198180044686, 1, sort: Players.sort.top);
                var playerscore0 = await scoreSaberClient.Api.Players.GetPlayerScoreByCount(76561198180044686, 0, sort: Players.sort.recent);
                var playerscore4 = await scoreSaberClient.Api.Players.GetPlayerScoreByCount(76561198180044686, 4, sort: Players.sort.top);
                var playerscore10 = await scoreSaberClient.Api.Players.GetPlayerScoreByCount(76561198180044686, 10, sort: Players.sort.top);

                Assert.IsTrue(playerscoresPage1.First().Leaderboard.Id == playerscore1.Leaderboard.Id);
                Assert.IsTrue(playerscoresPageRecent1.First().Leaderboard.Id == playerscore0.Leaderboard.Id);
                Assert.IsTrue(playerscoresPage1[3].Leaderboard.Id == playerscore4.Leaderboard.Id);
                Assert.IsTrue(playerscoresPage2[1].Leaderboard.Id == playerscore10.Leaderboard.Id);
            }).GetAwaiter().GetResult();
        }
    }
}
