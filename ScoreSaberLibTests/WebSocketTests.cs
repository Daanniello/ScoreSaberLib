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
        private bool _webSocketHasPassedSubscribe = false;
        private bool _webSocketHasPassedDisconnect = false;

        [TestMethod]
        public void SubscribeToFeed()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                scoreSaberClient.Api.ScoreFeed.Connect();
                scoreSaberClient.Api.ScoreFeed.OnPlayReceived += ScoreFeed_OnPlayReceived;
                await Task.Delay(10000);
                Assert.IsTrue(_webSocketHasPassedSubscribe);
            }).GetAwaiter().GetResult();
        }

        private void ScoreFeed_OnPlayReceived(object sender, ScoreSaberLib.Models.ScoreFeedModel e)
        {
            if(e.CommandName == "score") _webSocketHasPassedSubscribe = true;
        }

        [TestMethod]
        public void Disconnect()
        {
            Task.Run(async () =>
            {
                var scoreSaberClient = new ScoreSaberClient();
                scoreSaberClient.Api.ScoreFeed.Connect();
                scoreSaberClient.Api.ScoreFeed.OnDisconnect += ScoreFeed_OnDisconnect;
                await Task.Delay(4000);
                scoreSaberClient.Api.ScoreFeed.Disconnect();
                await Task.Delay(5000);
                Assert.IsTrue(_webSocketHasPassedDisconnect);
            }).GetAwaiter().GetResult();
        }

        private void ScoreFeed_OnDisconnect(object sender, EventArgs e)
        {
            _webSocketHasPassedDisconnect = true;
        }
    }
}
