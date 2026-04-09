using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.TemplateMethod
{
    internal class GenerateReportTask: Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generate report");
        }
    }
}
