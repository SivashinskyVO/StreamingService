﻿namespace Entities.Models
{
    public class Role : Entity
    {
        public string? Name { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
