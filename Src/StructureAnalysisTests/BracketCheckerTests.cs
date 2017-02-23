using StructureAnalysis;
using Xunit;

namespace StructureAnalysisTests
{
    public class BracketCheckerTests
    {
        [Fact]
        public void NewBracketChecker_IsValidPattern_IsTrue()
        {
            var bracketChecker = new BracketChecker();

            Assert.Equal(true, bracketChecker.IsValidPattern);
        }

        [Theory]
        [InlineData("(")]
        [InlineData(")")]
        [InlineData("[")]
        [InlineData("]")]
        [InlineData("{")]
        [InlineData("}")]
        [InlineData("<")]
        [InlineData(">")]
        public void IsValidPattern_IsFalse(string pattern)
        {
            var bracketChecker = new BracketChecker();

            bracketChecker.CheckPattern(pattern);

            Assert.Equal(false, bracketChecker.IsValidPattern);
        }
    }
}