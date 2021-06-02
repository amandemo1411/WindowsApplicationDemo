using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplicationDemo
{
    public static class EmployeeData
    {
        /// <summary>
        /// Method to create list of employee
        /// </summary>
        /// <param name="employeeName"></param>
        /// <param name="salary"></param>
        /// <returns></returns>
        public static List<EmployeeModel> CreateEmployeeData(string employeeName, int salary)
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>()
            {
                new EmployeeModel
                {
                    EmployeeName = employeeName,
                    Salary = salary
                }
            };
            return employeeList;
        }
    }
}
