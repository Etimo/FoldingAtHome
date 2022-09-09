namespace FoldingAtHomeEtimo.HttpRepositories.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Thumb { get; set; }
        public string? Institution { get; set; }

        public string GetBase64()
        {
            if (Thumb == string.Empty)
            {
                return "images/headshot.jpg";
            }
            return $"data:image / gif; base64,{Thumb}";
        }
    }
}