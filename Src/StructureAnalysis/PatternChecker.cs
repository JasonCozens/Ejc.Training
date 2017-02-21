namespace StructureAnalysis
{
    public class PatternChecker
    {
        public PatternChecker()
        {
            IsValidPattern = true;
        }

        public bool IsValidPattern { get; private set; }

        public void CheckPattern(string pattern)
        {
            var openBracketCount = 0;
            foreach (var c in pattern)
            {
                openBracketCount = c == '(' ? openBracketCount + 1 : openBracketCount - 1;
                if (openBracketCount < 0) break;
            }
            IsValidPattern = openBracketCount == 0;
        }
    }
}
