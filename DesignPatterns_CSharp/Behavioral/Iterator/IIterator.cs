using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Iterator
{
    internal interface IIterator<T>
    {
        bool HasNext();

        T Current();

        void Next();
        
    }
}
