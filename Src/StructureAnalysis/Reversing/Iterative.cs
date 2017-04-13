using System;
using System.Collections.Generic;

namespace StructureAnalysis.Reversing
{
    public class Iterative<T>
    {
        public static object Reverse(List<T> list)
        {
            var output = new List<T>();
            foreach (T t in list)
            {
                output.Insert(0, t);
            }
            return output;
        }
    }
}
