using Newtonsoft.Json;
using ScoreSaberLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;

namespace ScoreSaberLib.Websockets
{
    public class ScoreFeed
    {
        private WebSocket _webSocket = new WebSocket("wss://scoresaber.com/ws");
        public event EventHandler<ScoreFeedModel> OnPlayReceived;

        public ScoreFeed()
        {

        }

        public void Connect()
        {
            _webSocket.OnMessage += _webSocket_OnMessage;
            _webSocket.Connect();
        }

        public void Disconnect()
        {
            _webSocket.Close();
        }

        private class ScoreSaberWebSocketModel
        {
            [JsonProperty("commandName")]
            public string CommandName { get; set; }
        }

        private void _webSocket_OnMessage(object sender, MessageEventArgs e)
        {
            try
            {
                if (e.Data == "Connected to the ScoreSaber WSS") return;
                var webSocketData = JsonConvert.DeserializeObject<ScoreSaberWebSocketModel>(e.Data);
                if (webSocketData.CommandName == "score")
                {
                    var scoreFeedData = JsonConvert.DeserializeObject<ScoreFeedModel>(e.Data);
                    PlayReceived(scoreFeedData);
                }
            }
            catch
            {
                return;
            }
        }

        protected virtual void PlayReceived(ScoreFeedModel e)
        {
            EventHandler<ScoreFeedModel> handler = OnPlayReceived;
            handler?.Invoke(this, e);
        }
    }
}
