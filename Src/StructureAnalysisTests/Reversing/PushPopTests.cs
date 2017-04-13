using System.Collections.Generic;
using StructureAnalysis.Reversing;
using Xunit;

namespace StructureAnalysisTests.Reversing
{
    public class PushPopTests
    {
        [Fact]
        public void EmptyList_EmptyLitst()
        {
            var outputList = PushPop<int>.Reverse(new List<int>());

            Assert.Equal(new List<int>(), outputList);
        }

        [Fact]
        public void SingleElementList_SingleElementList()
        {
            var outputList = PushPop<int>.Reverse(new List<int> { 3 });

            Assert.Equal(new List<int> { 3 }, outputList);
        }

        [Fact]
        public void TwoElementList_ReverseTwoElementList()
        {
            var outputList = PushPop<int>.Reverse(new List<int> { 3, 5 });

            Assert.Equal(new List<int> { 5, 3 }, outputList);
        }
    }
}
