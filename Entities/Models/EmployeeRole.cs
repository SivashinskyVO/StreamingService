namespace Entities.Models
{
    public class EmployeeRole : Entity
    {
        public string? Name { get; set; }

        public ICollection<EmployeeFilm>? EmployeeFilms { get; set; }
    }
}
