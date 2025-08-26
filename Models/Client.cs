namespace desafioNubank.Models
{
    public class Client
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int[] ContactIds { get; set; } = [];
    }
}
