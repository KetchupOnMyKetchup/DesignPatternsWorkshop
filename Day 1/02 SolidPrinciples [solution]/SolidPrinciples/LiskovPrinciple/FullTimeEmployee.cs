using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovPrinciple
{
    public class FullTimeEmployee : IEmployee, IProject
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
}
