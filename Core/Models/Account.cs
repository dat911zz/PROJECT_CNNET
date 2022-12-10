using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Account
    {
        private string username;
        private string password;
        private int employeeId;
        public Account()
        {
        }
        public Account(string username, string password, int employeeId)
        {
            Username = username;
            Password = password;
            EmployeeId = employeeId;
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
    }
}
