using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Film : Entity
    {
        public string? Name { get; set; }
        public TimeSpan RunningTime { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string? PG { get; set; }
        public decimal? Score { get; set; }
        public string? Image { get; set; }
        public string? URL { get; set; }
        public string? Description { get; set; }

        public ICollection<Employee>? Employees { get; set; }
        public ICollection<EmployeeFilm>? EmployeeFilms { get; set; }
        public ICollection<Genre>? Genres { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
    }
}
