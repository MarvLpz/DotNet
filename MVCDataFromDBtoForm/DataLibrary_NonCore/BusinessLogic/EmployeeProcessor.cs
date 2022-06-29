using DataLibrary_NonCore.DataAccess;
using DataLibrary_NonCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary_NonCore.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName, string lastName, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };
            //@ in start of sql string is for multiple lines without the help of +
            //@ in value is parameterized sql. @ symbol indicates its a variable from data. combos with in (sql, data)
            string sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAddress)
                        values (@EmployeeId, @FirstName, @LastName, @EmailAddress);";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static int num() {
            return 1;
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, FirstName, LastName, EmailAddress
                        from dbo.Employees;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
