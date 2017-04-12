using System.Collections.Generic;

namespace StructureAnalysis.Reversing
{
    public class Recursive<T>
    {
        public static IList<T> Reverse(IList<T> inputList)
        {
            if (inputList.Count < 2)
            {
                return inputList;
            }
            var first = inputList[0];
            inputList.RemoveAt(0);
            var reversed = Reverse(inputList);
            reversed.Insert(reversed.Count, first);
            return reversed;
        }
    }
}
