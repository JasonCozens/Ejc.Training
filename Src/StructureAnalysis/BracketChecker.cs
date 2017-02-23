using System;
using System.Collections.Generic;

namespace StructureAnalysis
{
    public class BracketChecker
    {
        public BracketChecker()
        {
            IsValidPattern = true;
        }

        public bool IsValidPattern { get; set; }

        public void CheckPattern(string pattern)
        {
            IsValidPattern = false;
        }
    }
}