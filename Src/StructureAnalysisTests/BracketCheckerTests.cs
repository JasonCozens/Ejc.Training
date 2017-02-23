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
    }
}
