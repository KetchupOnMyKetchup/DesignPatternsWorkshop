using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovPrinciple
{
    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }
}
