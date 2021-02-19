using System;

namespace ProjectOrganizer.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }

        public int DepartmentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }


        public DateTime HireDate { get; set; }
    }








}

