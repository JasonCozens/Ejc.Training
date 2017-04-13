using System;
using System.Collections.Generic;

namespace StructureAnalysis.Reversing
{
    public class PushPop<T>
    {
        public static object Reverse(List<T> list)
        {
            var stack = new Stack<T>();
            var output = new List<T>();
            foreach (var t in list)
            {
                stack.Push(t);
            }
            while (stack.Count > 0)
            {
                output.Add(stack.Pop());
            }
            return output;
        }
    }
}
