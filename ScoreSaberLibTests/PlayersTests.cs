using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreSaberLib;
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
                Assert.IsTrue(player.First().Name == "Silverhaze");
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
                var playerscores = await scoreSaberClient.Api.Players.GetPlayerScores(76561198033166451, limit: 1, sort: Players.sort.top, page: 1);
                Assert.IsTrue(playerscores.First() != null);
            }).GetAwaiter().GetResult();
        }
    }
}
