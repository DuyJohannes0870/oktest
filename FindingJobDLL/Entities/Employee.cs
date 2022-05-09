﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FindingJobDLL.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            Cvs = new HashSet<Cv>();
        }

        public string EmployeeId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CityId { get; set; }

        public virtual User EmployeeNavigation { get; set; }
        public virtual ICollection<Cv> Cvs { get; set; }
    }
}
