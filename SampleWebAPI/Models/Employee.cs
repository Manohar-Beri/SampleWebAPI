using System;
using System.Collections.Generic;

namespace SampleWebAPI.Models
{
    public partial class Employee
    {
        public string name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public string Gender { get; set; }
        public int? Salary { get; set; }
    }
}
