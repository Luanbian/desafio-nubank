namespace desafioNubank.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int ClientId { get; set; }
    }
}
