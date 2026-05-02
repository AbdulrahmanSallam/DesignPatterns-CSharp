using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Structural.Composite.Solution
{
    public class Shape : IComponent
    {

        public void Render()
        {
            Console.WriteLine("Render");
        }
        public void Move()
        {
            Console.WriteLine("move");
        }
    }
}
