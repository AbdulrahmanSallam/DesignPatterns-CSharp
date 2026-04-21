using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Visitor
{
    
    public interface IHtmlNode
    {
        void Execute(IOperation operation); // accept(visitor)
    }



}
