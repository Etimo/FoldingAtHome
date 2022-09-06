namespace FoldingAtHomeEtimo.HttpRepository
{
    public record Project
    {
        public int Id { get; set; }
        public int Description { get; set; }
        public string? Manager { get; set; }
        public string? Modified { get; set; }
    }
}
