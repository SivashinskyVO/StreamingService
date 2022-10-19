namespace Entities.Models
{
    public class EmployeeFilm : Entity
    {
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public int FilmId { get; set; }
        public Film? Film { get; set; }

        public int EmployeeRoleId { get; set; }
        public EmployeeRole? EmployeeRole { get; set; }
    }
}
