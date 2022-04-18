# ScoreSaberLib
 Scoresaber API library

Changes from 2.1 to 2.2.
- Added ScoreFeed (a websocket that will send you live plays when subscribed)

A scoresaber api library to easily use functions on the scoresaber API 
Install with Nuget https://www.nuget.org/packages/ScoreSaberLib/

*Examples:*\
**Get a player by name**\
*//create a scoresaber client*\
`var scoresaberClient = new ScoreSaberClient();`\
*//use the API to navigate to various endpoints*\
*//and use their functions*\
*//In this example we are using [Players]*\
`var playerListNamedSilverhaze = await scoresaberClient.API.Players.GetPlayers(search: "silverhaze", page: 1, countryCodes: "NL")`;

**Subscribe to live scores**\
//Create a new Scoresaber client, connect with the scorefeed and subscribe to the OnPlayReceived event.\
`var scoreSaberClient = new ScoreSaberClient();`\
 `scoreSaberClient.Api.ScoreFeed.Connect();`\
` scoreSaberClient.Api.ScoreFeed.OnPlayReceived += ScoreFeed_OnPlayReceived;`


**What endpoints are there?**\
`scoresaberClient.API`\
`scoresaberClient.API.Leaderboards`\
`scoresaberClient.API.Players`\
`scoresaberClient.API.RankingRequests`\
`scoresaberClient.API.ScoreFeed`

*Leaderboards*\
For API calls towards finding the global leaderboard, in the future also country leaderboards etc.

*Players*\
For API calls towards finding info about players/player. By-Name, ByID, Recentsongs, TopSongs etc.

*RankingRequests*\
For API calls towards finding info about maps that are about to get ranked.

*ScoreFeed*\
For getting live Score data when players played a map. 
 

For more info: https://docs.scoresaber.com/#/

*Tags:\
Scoresaber, Scoresaber api, BeatSaber, Beat Saber api*
