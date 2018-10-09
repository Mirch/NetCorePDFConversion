using PdfGenerationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfGenerationTest.Utils
{
    public class Generator
    {
        public static string ObjectToHTML(Employee employee)
        {
            var sb = new StringBuilder();
            sb.AppendFormat(@"<html>
                            <head></head>
                           <body>
                                <h1>Name: {0}</h1>
                                <h2>Age: {1}</h2>
                                <h2>Age: {2}</h2>
                           </body>
                        </html>", employee.Name, employee.CPR, employee.Age);

            return sb.ToString();
        }
    }
}
