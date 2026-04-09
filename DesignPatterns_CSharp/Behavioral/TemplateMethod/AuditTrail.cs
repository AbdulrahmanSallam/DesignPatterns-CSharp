using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.TemplateMethod
{
    internal class AuditTrail
    {
        public void Record() {
            Console.WriteLine("Audit");
        }
    }
}
