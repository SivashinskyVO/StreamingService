using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Rating : Entity
    {
        public decimal? Score { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public int FilmId { get; set; }
        public Film? Film { get; set; }
    }
}
