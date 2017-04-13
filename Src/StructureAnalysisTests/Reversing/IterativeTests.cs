using System.Collections.Generic;
using StructureAnalysis.Reversing;
using Xunit;

namespace StructureAnalysisTests.Reversing
{
    public class IterativeTests
    {
        [Fact]
        public void EmptyList_EmptyLitst()
        {
            var outputList = Iterative<int>.Reverse(new List<int>());

            Assert.Equal(new List<int>(), outputList);
        }
    }
}