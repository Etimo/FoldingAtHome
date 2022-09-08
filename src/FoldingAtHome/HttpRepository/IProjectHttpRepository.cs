using FoldingAtHomeEtimo.HttpRepository.Models;

namespace FoldingAtHomeEtimo.HttpRepository
{

    public interface IProjectHttpRepository
{
        Task<List<Project>> GetProjects();
        Task<List<Manager>> GetProjectManagers();
        Task<Manager> GetManager(int managerId);
}
}
