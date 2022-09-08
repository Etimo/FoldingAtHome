using FoldingAtHomeEtimo.HttpRepositories.Models;

namespace FoldingAtHomeEtimo.HttpRepositories
{
    public interface ITeamHttpRepository
    {
        Task<List<TopTeam>> GetTop1000Teams();
        Task<List<Team>> GetTeams(int? month, int? year);
        Task<TeamDetailed> GetTeam(int teamId);
    }
}
