using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.TemplateMethod
{
    internal class TransferMoneyTask: Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer money");
        }
    }
}
