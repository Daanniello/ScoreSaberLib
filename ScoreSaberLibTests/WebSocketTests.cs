using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreSaberLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSaberLibTests
{
    [TestClass]
    public class WebSocketTests
    {
        private bool _webSocketHasPassed = false;

        [TestMethod]
        public void SubscribeToFeed()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                scoreSaberClient.Api.ScoreFeed.Connect();
                scoreSaberClient.Api.ScoreFeed.OnPlayReceived += ScoreFeed_OnPlayReceived;
                await Task.Delay(5000);
                Assert.IsTrue(_webSocketHasPassed);
            }).GetAwaiter().GetResult();
        }

        private void ScoreFeed_OnPlayReceived(object sender, ScoreSaberLib.Models.ScoreFeedModel e)
        {
            if(e.CommandName == "score") _webSocketHasPassed = true;
        }
    }
}
