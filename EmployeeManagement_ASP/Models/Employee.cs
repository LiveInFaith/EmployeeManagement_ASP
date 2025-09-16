using Microsoft.VisualBasic;

namespace EmployeeManagement_ASP.Models
{
    public class Employee : UserActivity
    {
        public int ID { get; set; }

        public int EmpNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public DateTime DayOfBirth { get; set; }

        public string Address { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        
    }
}
