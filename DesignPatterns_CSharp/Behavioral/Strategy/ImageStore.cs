using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Strategy
{
    internal static  class ImageStore
    {

        public static void Store(string fileName, ICompression compression, IFilter filter)
        {

            compression.Compress(fileName);

            filter.Apply(fileName);
        }


    }
}
