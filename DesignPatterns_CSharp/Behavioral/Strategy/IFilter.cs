using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Strategy
{
    internal interface IFilter
    {
        void Apply(string fileName);
    }
}
