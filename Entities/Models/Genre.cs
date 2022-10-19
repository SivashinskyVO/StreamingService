namespace Entities.Models
{
    public class Genre : Entity
    {
        public string? Name { get; set; }

        public ICollection<Film>? Films { get; set; }
    }
}
