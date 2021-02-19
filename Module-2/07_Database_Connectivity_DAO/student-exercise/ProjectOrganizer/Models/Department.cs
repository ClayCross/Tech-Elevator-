using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }
        public object Id { get; internal set; }
    }
}
