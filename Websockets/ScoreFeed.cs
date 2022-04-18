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

        private void _webSocket_OnMessage(object sender, MessageEventArgs e)
        {
            if(e.Data != "Connected to the ScoreSaber WSS")
            {
                var scoreFeedObject = JsonConvert.DeserializeObject<ScoreFeedModel>(e.Data);
                PlayReceived(scoreFeedObject);
            }
        }

        protected virtual void PlayReceived(ScoreFeedModel e)
        {
            EventHandler<ScoreFeedModel> handler = OnPlayReceived;
            handler?.Invoke(this, e);
        }
    }
}
