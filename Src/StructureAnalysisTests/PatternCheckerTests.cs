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

        [Fact]
        public void SingleCharacter_IsValidPattern_IsFalse()
        {
            var patternChecker = new PatternChecker();

            patternChecker.CheckPattern(")");

            Assert.Equal(false, patternChecker.IsValidPattern);
        }

        [Fact]
        public void OpenCloseBrackets_IsValidPattern_IsFalse()
        {
            var patternChecker = new PatternChecker();

            patternChecker.CheckPattern("()");

            Assert.Equal(true, patternChecker.IsValidPattern);
        }
    }
}
