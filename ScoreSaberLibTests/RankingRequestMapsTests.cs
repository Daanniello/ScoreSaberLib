using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreSaberLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSaberLibTests
{
    [TestClass]
    public class RankingRequestMapsTests
    {
        [TestMethod]
        public void GetRankRequest()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var requestedMap = await scoreSaberClient.Api.RankingRequests.GetRequest(6534);
                Assert.IsTrue(requestedMap.RequestId == 6534);
            }).GetAwaiter().GetResult();
        }

        [TestMethod]
        public void GetRankRequestByLeaderboardID()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                var requestedMap = await scoreSaberClient.Api.RankingRequests.GetRequestByLeaderboardID(355184);
                Assert.IsTrue(requestedMap.LeaderboardInfo.Id == 355184);
            }).GetAwaiter().GetResult();
        }
    }
}
