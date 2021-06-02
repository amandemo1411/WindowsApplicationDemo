using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplicationDemo
{
    public static class ProcessEmployee
    {
        /// <summary>
        /// Method to process employee
        /// </summary>
        /// <param name="employeeName"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static bool ProcessEmployeeData(string employeeName, int amount)
        {
            List<EmployeeModel> list = EmployeeData.CreateEmployeeData(employeeName, amount);
            if(list.Count > 0)
                return true;
            return false;
        }
    }
}
