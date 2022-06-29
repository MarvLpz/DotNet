using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is a Model directly for a database
namespace DataLibrary.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; } //Should pattern exactly as what's in the database. thats why we created Id
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress{ get; set; }
    }
}
