using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciples.SingleResponsibilityPrinciple;

namespace SolidPrinciples.OpenClosePrinciple
{
    interface IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        void GenerateReport(Employee em);
    }
}
