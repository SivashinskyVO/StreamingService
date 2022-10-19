namespace Entities.Models
{
    public class User : Entity
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Image { get; set; }

        public string? RoleId { get; set; }
        public Role? Role { get; set; }

        public ICollection<Rating>? Ratings { get; set; }
    }
}
