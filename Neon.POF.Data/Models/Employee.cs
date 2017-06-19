using System.Collections.Generic;

namespace Neon.POF.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public ICollection<DepartmentEmployee> DepartmentEmployees { get; set; }
    }
}