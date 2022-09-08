using System.Text.Json.Serialization;

namespace FoldingAtHomeEtimo.HttpRepositories.Models
{
    public record TopTeam
    (
        string Name,
        [property: JsonPropertyName("team")] int Id,
        [property: JsonPropertyName("credit")] float Score,
        [property: JsonPropertyName("wus")] int WorkUnits,
        string Founder,
        Uri? Url,
        Uri? Logo
    )
    {
        public bool IsDefaultTeam => Id == 0;
    }
}
