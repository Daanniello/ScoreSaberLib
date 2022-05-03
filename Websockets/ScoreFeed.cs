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
        public WebSocket WebSocket = new WebSocket("wss://scoresaber.com/ws");
        public event EventHandler<ScoreFeedModel> OnPlayReceived;
        public event EventHandler OnDisconnect;

        public ScoreFeed()
        {

        }

        public void Connect()
        {
            WebSocket.OnMessage += _webSocket_OnMessage;
            WebSocket.OnClose += _webSocket_OnDisconnect;
            WebSocket.Connect();
        }

        public void Disconnect()
        {
            WebSocket.Close();
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

        private void _webSocket_OnDisconnect(object sender, CloseEventArgs e)
        {
            EventHandler handler = OnDisconnect;
            handler?.Invoke(this, e);
        }
    }
}
