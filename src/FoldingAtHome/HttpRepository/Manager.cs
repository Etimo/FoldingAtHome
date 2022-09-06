namespace FoldingAtHomeEtimo.HttpRepository
{
    public record Manager
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Thumb { get; set; }
        public string? Institution  { get; set; }
    }
}