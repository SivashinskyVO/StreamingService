namespace Entities.Models
{
    public class Employee : Entity
    {
        public string? Fullname { get; set; }
        public ICollection<Film>? Films { get; set; }
        public ICollection<EmployeeFilm>? EmployeeFilms { get; set; }
    }
}
