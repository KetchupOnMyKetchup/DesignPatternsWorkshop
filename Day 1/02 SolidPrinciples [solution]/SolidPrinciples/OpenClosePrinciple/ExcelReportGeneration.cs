using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciples.SingleResponsibilityPrinciple;

namespace SolidPrinciples.OpenClosePrinciple
{
    /// <summary>
    /// Class to generate Excel report
    /// </summary>
    public class ExcelReportGeneraion : IReportGeneration
    {
        public void GenerateReport(Employee em)
        {
            // Generate excel report.
        }
    }
}
