# ScoreSaberLib
 Scoresaber API library

A scoresaber api library to easily use functions on the scoresaber API 

*Examples:*\
**Get a player by name**\
*//create a scoresaber client*\
`var scoresaberClient = new ScoreSaberClient();`\
*//use the API to navigate to various endpoints*\
*//and use their functions*\
*//In this example we are using [Players]*\
`var playerListNamedSilverhaze = await scoresaberClient.API.Players.GetPlayers(search: "silverhaze", page: 1, countryCodes: "NL")`;


**What endpoints are there?**\
`scoresaberClient.API` contains at the moment 3 categories.

*Leaderboards*\
For API calls towards finding the global leaderboard, in the future also country leaderboards etc.

*Players*\
For API calls towards finding info about players/player. By-Name, ByID, Recentsongs, TopSongs etc.

*RankingRequests*\
For API calls towards finding info about maps that are about to get ranked.
 

For more info: https://docs.scoresaber.com/#/

*Tags:\
Scoresaber, Scoresaber api, BeatSaber, Beat Saber api*
