using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Employees
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? PhoneNumber { get; set; }   
        public string? Email { get; set; }  
    }
}