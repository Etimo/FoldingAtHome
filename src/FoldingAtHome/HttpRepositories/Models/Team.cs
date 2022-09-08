using System.Text.Json.Serialization;

namespace FoldingAtHomeEtimo.HttpRepositories.Models
{
    public record Team
    (
        string Name,
        [property: JsonPropertyName("team")] int Id,
        [property: JsonPropertyName("credit")] int Score,
        [property: JsonPropertyName("wus")]int WorkUnits
    )
    {
        public bool IsDefaultTeam => Id == 0;
    }
}
