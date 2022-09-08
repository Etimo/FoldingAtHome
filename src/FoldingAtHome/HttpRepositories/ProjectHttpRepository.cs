using System.Text.Json;
using FoldingAtHomeEtimo.HttpRepositories.Models;

namespace FoldingAtHomeEtimo.HttpRepositories
{
    public class ProjectHttpRepository : IProjectHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public ProjectHttpRepository(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<List<Project>> GetProjects()
        {
            var response = await _client.GetAsync("project");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var products = JsonSerializer.Deserialize<List<Project>>(content, _options);
            return products;
        }

        public async Task<Manager> GetManager(int managerId)
        {
            var response = await _client.GetAsync($"project/manager/{managerId}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var manager = JsonSerializer.Deserialize<Manager>(content, _options);
            return manager;
        }

       public async Task<List<Manager>> GetProjectManagers()
        {
            var response = await _client.GetAsync("project/manager");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var managers = JsonSerializer.Deserialize<List<Manager>>(content, _options);
            return managers;
        }
    }
}
