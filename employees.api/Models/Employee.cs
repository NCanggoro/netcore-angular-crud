using System;

namespace employees.api.Models
{
    public class Employee
    {
        public Guid id { get; set; }

        public string Name { get; set; }

        public string Wage { get; set; }

    }
}