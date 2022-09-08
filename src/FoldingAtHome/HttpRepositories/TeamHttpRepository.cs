using System.Text.Json;
using FoldingAtHomeEtimo.HttpRepositories.Models;

namespace FoldingAtHomeEtimo.HttpRepositories;

class TeamHttpRepository : ITeamHttpRepository
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _options;

    public TeamHttpRepository(HttpClient client)
    {
        _client = client;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }
    public async Task<List<TopTeam>> GetTop1000Teams()
    {
        var response = await _client.GetAsync("team");
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        var teams = JsonSerializer.Deserialize<List<TopTeam>>(content, _options);
        return teams;
    }

    public async Task<List<Team>> GetTeams(int month, int year)
    {
        var response = await _client.GetAsync($"team/monthly?month={month}&year={year}");
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        var teams = JsonSerializer.Deserialize<List<Team>>(content, _options);
        return teams;
    }

    public async Task<TeamDetailed> GetTeam(int id)
    {
        var response = await _client.GetAsync($"team/{id}");
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        var team = JsonSerializer.Deserialize<TeamDetailed>(content, _options);
        return team;
    }
}