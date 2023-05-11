using DomainLayer.Entities;

HttpClient httpClient = new HttpClient();

string apiKey = "018c7ba508536c2b310be5eabf523dae";

string apiBaseUrl = "https://v3.football.api-sports.io";

string nextLeagueMatches = "/fixtures?league=61&next=10";


string playedMatchesSeason2022 = "/fixtures?league=61&season=2022&status=FT";

string nextFRMatches = "/fixtures?league=61&next=1";

string lineUpByTeamId = "/players?team=95&season=2022"; //strasbourg : 95

string playerStatistics = "/players?id=21633&team=95&season=2022&last=1";

//https://v3.football.api-sports.io/fixtures?league=61&team=75&last=10
//https://v3.football.api-sports.io/fixtures/lineups?fixture={FIXTURE_ID}&team={TEAM_ID} //compo pour un match
//https://v3.football.api-sports.io/players/{PLAYER_ID}/statistics?league=61&last=10



string url = apiBaseUrl + playerStatistics;

var request = new HttpRequestMessage(HttpMethod.Get, url);
request.Headers.Add("x-rapidapi-key", apiKey);
request.Headers.Add("x-rapidapi-host", "v3.football.api-sports.io");

var response = httpClient.SendAsync(request).Result;
var responseString = await response.Content.ReadAsStringAsync();


//var matchResults = JsonConvert.DeserializeObject<IEnumerable<MatchResultDto>>(responseString);


//Console.WriteLine(responseString);

MatchPlayed match = new MatchPlayed(1,DateTime.Now, new League(1,"Ligue 1","2022-23","France"),new DomainLayer.Team(1, "Strasbourg"),new DomainLayer.Team(2,"Rennes"),2,0,
    new MatchTeamStatistics(), new MatchTeamStatistics());

MatchToPlay match2 = new MatchToPlay(1, DateTime.Now, new League(1, "Ligue 1", "2022-23", "France"), new DomainLayer.Team(1, "Strasbourg"), new DomainLayer.Team(2, "Rennes"));

Console.WriteLine(match2);
Console.ReadLine();


Team myTeam = new Team { Name = "My Team", Size = 10 };
string json = JsonConvert.SerializeObject(myTeam);

