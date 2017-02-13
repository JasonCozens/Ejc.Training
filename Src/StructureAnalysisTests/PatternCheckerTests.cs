using StructureAnalysis;
using Xunit;

namespace StructureAnalysisTests
{
    public class PatternCheckerTests
    {
        [Fact]
        public void NewPatternChecker_IsValidPattern_IsTrue()
        {
            var patternChecker = new PatternChecker();

            Assert.Equal(true, patternChecker.IsValidPattern);
        }
    }
}
