using System;

namespace AuditionService.Models
{
    public class Employee : Entity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }
    }
}