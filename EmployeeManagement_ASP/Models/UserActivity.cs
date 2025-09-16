using Microsoft.VisualBasic;

namespace EmployeeManagement_ASP.Models
{
    public class UserActivity
    {
        public string? CreatedById { get; set; }

        public DateTime CreatedOn { get; set; }

        public string? ModifiedByID { get; set; }

        public DateTime ModifiedOn { get; set;}
    }
}
