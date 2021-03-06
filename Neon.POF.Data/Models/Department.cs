﻿using System.Collections.Generic;

namespace Neon.POF.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public ICollection<DepartmentEmployee> DepartmentEmployees { get; set; }
    }
}