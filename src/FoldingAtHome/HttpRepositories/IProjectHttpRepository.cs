using FoldingAtHomeEtimo.HttpRepositories.Models;

namespace FoldingAtHomeEtimo.HttpRepositories
{

    public interface IProjectHttpRepository
{
        Task<List<Project>> GetProjects();
        Task<List<Manager>> GetProjectManagers();
        Task<Manager> GetManager(int managerId);
}
}
