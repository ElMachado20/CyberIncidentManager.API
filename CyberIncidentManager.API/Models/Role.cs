﻿namespace CyberIncidentManager.API.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Permissions { get; set; }

        public ICollection<User> Users { get; set; }
    }
}