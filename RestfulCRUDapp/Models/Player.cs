namespace RestfulCRUDapp.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? TeamName { get; set; }
        public string? Position  { get; set; }
    }
}
