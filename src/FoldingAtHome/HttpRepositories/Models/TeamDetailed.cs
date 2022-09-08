using System.Text.Json.Serialization;

namespace FoldingAtHomeEtimo.HttpRepositories.Models
{
    public record TeamDetailed
    (
        int Id,
        string Name,
        string Founder,
        Uri? Logo,
        Uri? Url,
        int Rank,
        int Score,
        [property: JsonPropertyName("wus")] int WorkUnits
    )
    {
        public bool IsDefaultTeam => Id == 0;
    }
}
