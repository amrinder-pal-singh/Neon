using System.Collections.Generic;

namespace Neon.POF.Data.Models
{
    public class DepartmentEmployee
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
    }
}