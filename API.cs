using ScoreSaberLib.Websockets;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreSaberLib
{
    public class API
    {
        public Leaderboards Leaderboards = new Leaderboards();
        public Players Players = new Players();        
        public RankingRequests RankingRequests = new RankingRequests();
        public ScoreFeed ScoreFeed = new ScoreFeed();
    }
}
