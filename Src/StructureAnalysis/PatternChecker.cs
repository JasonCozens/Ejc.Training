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
            if (pattern.Length < 2)
            {
                IsValidPattern = false;
            }
        }
    }
}
