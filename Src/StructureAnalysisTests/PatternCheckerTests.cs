using StructureAnalysis;
using Xunit;

namespace StructureAnalysisTests
{
    /// <summary>
    /// We know that as we work through a pattern "(".Count >= ")".Count
    /// At the end "(".Count = 0 if the string match.
    /// </summary>
    public class PatternCheckerTests
    {
        [Fact]
        public void NewPatternChecker_IsValidPattern_IsTrue()
        {
            var patternChecker = new PatternChecker();

            Assert.Equal(true, patternChecker.IsValidPattern);
        }

        [Theory]
        [InlineData(")")]
        [InlineData("))")]
        [InlineData(")(")]
        [InlineData("((")]
        [InlineData("()(")]
        [InlineData("()((")]
        public void IsValidPattern_IsFalse(string pattern)
        {
            var patternChecker = new PatternChecker();

            patternChecker.CheckPattern(pattern);

            Assert.Equal(false, patternChecker.IsValidPattern);
        }

        [Theory]
        [InlineData("()")]
        [InlineData("()()")]
        [InlineData("(())")]
        public void IsValidPattern_IsTrue(string pattern)
        {
            var patternChecker = new PatternChecker();

            patternChecker.CheckPattern(pattern);

            Assert.Equal(true, patternChecker.IsValidPattern);
        }
    }
}
